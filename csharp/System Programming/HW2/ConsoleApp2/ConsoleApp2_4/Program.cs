using System;
using System.Diagnostics;
using System.Management;
using System.Threading;
using System.Threading.Tasks;
using System.Management;
using System.Dynamic;

namespace ConsoleApp2_4
{
    class Program
    {
        static Timer timer;
        static void Main(string[] args)
        {
            timer = new Timer(CallBackMethod, null, 0, 5000);

            Console.WriteLine("Таймер запущен. Нажмите Enter для выхода.");
            Console.ReadLine();

            // Остановка таймера
            timer.Dispose();
        }

        public static async Task CallBackMethod(object state)
        {
            Usage usage = new Usage();
            Console.WriteLine($"Time: {DateTime.Now}\tCPU: {usage.getCurrentCpuUsage()}\tRAM: {usage.getAvailableRAM()} ");
            usage.getTotalAndAvailableRAM();


            dynamic result = await usage.GetUsageAsync();
            string stats = $"Memory Usage: {result.RAM} MB, CPU Usage: {result.CPU}%";             
        }

        public class Usage
        {
            private PerformanceCounter cpuCounter;
            private PerformanceCounter ramCounter;
            
            public Usage()
            {
                cpuCounter = new PerformanceCounter("Processor", "% Processor Time", "_Total");                
                ramCounter = new PerformanceCounter("Memory", "Available MBytes");
            }

            public async Task<dynamic> GetUsageAsync()
            {
                var process = Process.GetCurrentProcess();
                var name = string.Empty;

                foreach (var instance in new PerformanceCounterCategory("Process").GetInstanceNames())
                {
                    if (instance.StartsWith(process.ProcessName))
                    {
                        using var processId = new PerformanceCounter("Process", "ID Process", instance, true);
                        if (process.Id == (int)processId.RawValue)
                        {
                            name = instance;
                            break;
                        }
                    }
                }

                var cpu = new PerformanceCounter("Process", "% Processor Time", name, true);
                var ram = new PerformanceCounter("Process", "Private Bytes", name, true);

                cpu.NextValue();
                ram.NextValue();

                await Task.Delay(500);
                dynamic result = new ExpandoObject();

                result.CPU = Math.Round(cpu.NextValue() / Environment.ProcessorCount, 2);
                result.RAM = Math.Round(ram.NextValue() / 1024 / 1024, 2); // MB

                return result;
            }

            /*            
            If you try this is will often just report 0,
            the reason being is that the PerformanceCounter object needs 2
            values to give an accurate reading. This might lead you to think
            that inserting cpuCounter.NextValue() before the return line would fix the problem
            however this is not the case. These counters tend to only be updated about once or twice a second
            so calling it twice in succession would likely just return the same value.
            */
            public string getCurrentCpuUsage()
            {
                return cpuCounter.NextValue() + "%";
            }


            //public void getCurrentCpuUsage()
            //{
            //    var cpuCounter = new PerformanceCounter("Processor", "% Processor Time", "_Total", "MyComputer");
            //    cpuCounter.NextValue();
            //    System.Threading.Thread.Sleep(1000);                
            //}

            public string getAvailableRAM()
            {               
                return ramCounter.NextValue() + "MB";
            }     
            
            public void getTotalAndAvailableRAM()
            {
                ObjectQuery objectQuery = new ObjectQuery("SELECT * FROM Win32_OperatingSystem");
                ManagementObjectSearcher managementObjectSearcher = new ManagementObjectSearcher(objectQuery);
                ManagementObjectCollection managementObjectCollection = managementObjectSearcher.Get();
                foreach (ManagementObject managementObject in managementObjectCollection)
                {
                    Console.WriteLine("Total Visible Memory: {0} KB", managementObject["TotalVisibleMemorySize"]);
                    Console.WriteLine("Free Physical Memory: {0} KB", managementObject["FreePhysicalMemory"]);

                    // Console.WriteLine("Total Virtual Memory: {0} KB", managementObject["TotalVirtualMemorySize"]);
                    // Console.WriteLine("Free Virtual Memory: {0} KB", managementObject["FreeVirtualMemory"]);
                }                
            }
        }
    }
}
