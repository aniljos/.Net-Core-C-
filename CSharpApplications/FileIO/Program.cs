using System.IO;

namespace FileIO
{

    public class Test : IDisposable
    {
        //constructors

        //destructors ==> no destructors
        //dispose ==> cleanup 
        public void Dispose()
        {
            Console.WriteLine("Test Dispose");
        }
    }


    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            //WriteToFile();
            // DisposeDemo();
            //WriteToFileWithUsing();
            ReadFromFile();
        }


        static void DisposeDemo()
        {
            using (Test test = new Test())
            {
                //some logic
            }//test.Dispose() is implicitly called ;



        }

        static void WriteToFile()
        {
            FileStream stream = null;
            StreamWriter writer = null;
            try
            {
                stream = new FileStream("data.txt", FileMode.Create);
                writer = new StreamWriter(stream);

                Console.WriteLine("Enter the text to save to file. Enter exit to stop");
                var text = Console.ReadLine();
                while(text != "exit")
                {
                    writer.WriteLine(text);
                    text = Console.ReadLine();
                }

                writer.Flush();
               
            }
            catch (Exception ex)
            {

                Console.WriteLine("Exception: " + ex.Message);
            }
            finally
            {
                if(writer != null)
                {
                    writer.Close();
                }
                if(stream != null)
                {
                    stream.Close();
                }
                
            }






        }

        static void WriteToFileWithUsing()
        {
           
            try
            {
                using (FileStream stream = new FileStream("data.txt", FileMode.Create))
                {
                    using (StreamWriter writer = new StreamWriter(stream))
                    {
                        Console.WriteLine("Enter the text to save to file. Enter exit to stop");
                        var text = Console.ReadLine();
                        while (text != "exit")
                        {
                            writer.WriteLine(text);
                            text = Console.ReadLine();
                        }

                        writer.Flush();
                    }
                }
            }
            catch (Exception ex)
            {

                Console.WriteLine("Exception: " + ex.Message);
            }
            






        }
    
        static void ReadFromFile()
        {
            try
            {
                using(FileStream stream = new FileStream("data.txt", FileMode.Open))
                {
                    using(StreamReader reader = new StreamReader(stream))
                    {
                        string text = reader.ReadLine();
                        while(text != null)
                        {
                            Console.WriteLine(text);
                            text = reader.ReadLine();
                        }
                    }
                }
            }
            catch (Exception ex)
            {

                Console.WriteLine($"Exception {ex.Message}");
            }
        }
    }
}