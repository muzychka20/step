/*
Создайте консольное приложение, которое моделирует процесс скачивания файла,
при этом уведомляет пользователя о прогрессе и завершении скачивания
с использованием делегатов и событий.

Условия:
Создайте класс FileDownloader, который будет отвечать за процесс скачивания файла.
В этом классе должно быть событие ProgressChanged, которое срабатывает при изменении прогресса скачивания,
и событие DownloadCompleted, которое срабатывает по завершении скачивания.

Для событий создайте делегаты:
ProgressChangedHandler — делегат для события изменения прогресса, который принимает процент выполнения (целое число).
DownloadCompletedHandler — делегат для события завершения скачивания.

Создайте класс UserInterface, который будет подписываться на события FileDownloader
и выводить в консоль сообщение о прогрессе скачивания и уведомлять о его завершении.

В классе FileDownloader реализуйте метод DownloadFile(), 
который будет эмулировать скачивание файла, обновляя прогресс каждые 500 миллисекунд. 
Прогресс должен увеличиваться от 0 до 100%, и при каждом изменении нужно вызывать событие ProgressChanged. По завершении скачивания вызовите событие DownloadCompleted.

В Main методе создайте экземпляр FileDownloader, подпишите методы UserInterface на события и выполните скачивание файла.

Дополнительные требования:
Эмулируйте скачивание файла с использованием цикла, который будет увеличивать прогресс с задержкой в 500 миллисекунд, пока не достигнет 100%.
Для события DownloadCompleted выведите сообщение о завершении и поздравление с успешным скачиванием файла.
*/

using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using System.Collections;

namespace ConsoleApp7
{
    public delegate void ProgressChangedHandler(int completedPercent);
    public delegate void DownloadCompletedHandler(string message);

    class UserInterface
    {
        public void OnNotifyReceivedChange(int per)
        {
            Console.WriteLine("User get message: " + per);
        }

        public void OnNotifyReceived(string message)
        {
            Console.WriteLine("User get message: " + message);
        }
    }

    class FileDownloader
    {
        public event ProgressChangedHandler NotifyProgressChanged;
        public event DownloadCompletedHandler NotifyDownloadCompletedHandler;


        public void ProgressChanged(int percent)
        {
            if (NotifyProgressChanged != null)
            {
                NotifyProgressChanged(percent);
            }
        }

        public void DownloadCompleted()
        {
            if (NotifyDownloadCompletedHandler != null)
            {
                NotifyDownloadCompletedHandler("File downloaded!");
            }
        }

        public void DownloadFile()
        {
            int percent = 0;
            while(percent < 100)
            {
                Thread.Sleep(500);
                percent += 10;
                ProgressChanged(percent);
            }
            DownloadCompleted();
        }
    }

    class Program
    {
        static void Main(string[] args)
        {            
            FileDownloader fileDownloader = new FileDownloader();
            UserInterface userInterface = new UserInterface();

            fileDownloader.NotifyProgressChanged += userInterface.OnNotifyReceivedChange;
            fileDownloader.NotifyDownloadCompletedHandler += userInterface.OnNotifyReceived;

            fileDownloader.DownloadFile();
        }
    }
}