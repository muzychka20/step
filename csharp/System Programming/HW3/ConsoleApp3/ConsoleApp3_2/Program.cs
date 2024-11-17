using System;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace ConsoleApp3_2
{
    class Program
    {
        static void Main(string[] args)
        {
            string sourceDir = @"C:\\lessons\\test\\";
            string backupDir = @"C:\\lessons\\resTest\\";

            // Создание файлов
            Parallel.For(1, 10_001, i =>
            {
                using (FileStream fs = File.Create(sourceDir + "file_" + i.ToString() + ".txt")) { }
            });


            // Копирование файлов
            string[] txtList = Directory.GetFiles(sourceDir, "*.txt");
            
            Parallel.ForEach(txtList, f => {
                // Remove path from the file name.
                string fName = f.Substring(sourceDir.Length);

                try
                {
                    // Will not overwrite if the destination file already exists.
                    File.Copy(Path.Combine(sourceDir, fName), Path.Combine(backupDir, fName));
                }
                catch (IOException copyError) // Catch exception if the file was already copied.
                {
                    Console.WriteLine(copyError.Message);
                }
            });


            // Получение списка файлов в папке
            string[] files = Directory.GetFiles(backupDir, "*.txt");

            // Сортировка по дате создания
            var iter = files.AsParallel()
                            .OrderByDescending(f => File.GetCreationTime(f))                            
                            .ToList();

            foreach (var el in iter)
            {
                Console.WriteLine($"{el}  |  {File.GetCreationTime(el)}");
            }
        }
    }
}
