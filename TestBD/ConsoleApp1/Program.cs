using System;
using System.Collections.Generic;
using System.Globalization;
using System.Threading;

public class Program
{
    private static Queue<string> requestQueue = new Queue<string>();
    private static object queueLock = new object();

    public static void Main()
    {
        //// Создаем несколько потоков для добавления запросов в очередь
        //for (int i = 0; i < 500; i++)
        //{
        //    Thread thread = new Thread(EnqueueRequest);
        //    thread.Start($"Request {i + 1}");
        //}

        //// Запускаем поток для обработки запросов из очереди
        //Thread processingThread = new Thread(ProcessRequests);
        //processingThread.Start();

        //// Ждем завершения всех потоков
        //processingThread.Join();
        //Console.WriteLine("All requests processed.");




        CultureInfo[] specificCultures = CultureInfo.GetCultures(CultureTypes.SpecificCultures);
        foreach (CultureInfo ci in specificCultures)
            Console.WriteLine(ci.DisplayName + " | " + ci.Name);
    }

    public static void EnqueueRequest(object request)
    {
        lock (queueLock)
        {
            requestQueue.Enqueue((string)request);
            Console.WriteLine($"Enqueued request: {request}");
        }
    }

    public static void ProcessRequests()
    {
        while (true)
        {
            string request;
            lock (queueLock)
            {
                if (requestQueue.Count == 0)
                {
                    // Если очередь пуста, выходим из цикла
                    break;
                }

                request = requestQueue.Dequeue();
            }

            // Обрабатываем запрос
            Console.WriteLine($"Processing request: {request}");
            //Thread.Sleep(1); // Имитация обработки запроса
        }
    }
}
public class DB {
    private unsafe Thread* threadAdd;
    private unsafe Stack<string>* stackP;
    public void addStack() {

    }




}
