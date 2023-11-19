using System.Linq.Expressions;

namespace ThreadsDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            Console.WriteLine($"Thread Name: {Thread.CurrentThread.Name}, ManagedId: {Thread.CurrentThread.ManagedThreadId}");
            Foo();

            //Thread thread = new Thread(new ThreadStart(Bar));
            //Thread thread = new Thread(Bar);
            //thread.Name = "bar-thread";
            //thread.IsBackground = true;
            //thread.Start();

            //Console.WriteLine($"WordCount: {GetWordCount("Hello World Threads")}");

            //GetFileWordCount(new string[]
            //        { "D:\\Applications\\.NET Core\\MyFiles\\Sample1.txt", "D:\\Applications\\.NET Core\\MyFiles\\Sample2.txt" });
            //GetFileWordCountWithThreads(new string[]
            //        { "D:\\Applications\\.NET Core\\MyFiles\\Sample1.txt", "D:\\Applications\\.NET Core\\MyFiles\\Sample2.txt" });
            GetFileWordCountWithTasks(new string[]
                    { "D:\\Applications\\.NET Core\\MyFiles\\Sample1.txt", "D:\\Applications\\.NET Core\\MyFiles\\Sample2.txt" });

            Console.WriteLine("Main is over");
        }

        static void GetFileWordCount(string[] filePaths)
        {
            foreach (var item in filePaths)
            {
                using (StreamReader reader = new StreamReader(item))
                {
                    string contents = reader.ReadToEnd();
                    int wordCount = GetWordCount(contents);
                    Console.WriteLine($"File: {item}, Word Count: {wordCount}");
                }

            }
        }

        static void GetFileWordCountWithThreads(string[] filePaths)
        {
            List<int> wordCounts = new List<int>();
            List<Thread> threads = new List<Thread>();
            foreach (var item in filePaths)
            {

                Thread thread = new Thread(() =>
                {
                    
                    using (StreamReader reader = new StreamReader(item))
                    {
                        string contents = reader.ReadToEnd();
                        int wordCount = GetWordCount(contents);
                        wordCounts.Add(wordCount);
                        Console.WriteLine($"File: {item}, Word Count: {wordCount}, Thread ManagedId: {Thread.CurrentThread.ManagedThreadId}");
                    }

                });
                threads.Add(thread);
                thread.Start();
            }

            foreach (var thread in threads)
            {
                thread.Join();
            }
            Console.WriteLine("WordsCount of the files");
            foreach (var count in wordCounts)
            {
                Console.WriteLine($"Item: {count}");
            }
        }


        static void GetFileWordCountWithTasks(string[] filePaths)
        {
            Console.WriteLine("GetFileWordCountWithTasks");
            List<int> wordCounts = new List<int>();
            List<Task> tasks = new List<Task>();
            foreach (var item in filePaths)
            {
                var task = Task.Run(() =>
                {
                    using (StreamReader reader = new StreamReader(item))
                    {
                        string contents = reader.ReadToEnd();
                        int wordCount = GetWordCount(contents);
                        wordCounts.Add(wordCount);
                        Console.WriteLine($"File: {item}, Word Count: {wordCount}, Thread ManagedId: {Thread.CurrentThread.ManagedThreadId}");
                    }
                });
                tasks.Add(task);

                
            }

            Task.WhenAll(tasks).Wait();

            Console.WriteLine("WordsCount of the files");
            foreach (var count in wordCounts)
            {
                Console.WriteLine($"Item: {count}");
            }
        }
        static void Foo()
        {
            Console.WriteLine("In Foo");
            Console.WriteLine($"Thread Name for Foo: {Thread.CurrentThread.Name}, ManagedId: {Thread.CurrentThread.ManagedThreadId}");
        }

        static void Bar()
        {
            Console.WriteLine("In Bar");
            Console.WriteLine($"Thread Name for Bar: {Thread.CurrentThread.Name}, ManagedId: {Thread.CurrentThread.ManagedThreadId}");
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("In bar " + i);
                Thread.Sleep(500);
            }
        }

        static int GetWordCount(string input)
        {
            if (string.IsNullOrEmpty(input))
            {
                return 0;
            }

            int wordCount = 0;
            bool isWord = false;

            foreach (char c in input)
            {
                if (char.IsLetter(c))
                {
                    if (!isWord)
                    {
                        isWord = true;
                        wordCount++;
                    }
                }
                else
                {
                    isWord = false;
                }
            }
            return wordCount;
        }
    }
}