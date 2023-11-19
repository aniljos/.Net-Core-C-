using Newtonsoft.Json;
using System.IO;
using System.Xml.Serialization;

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
            //ReadFromFile();
            //GenerateProductXML();
            GenerateProductJSON();
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
    
    
        static void GenerateProductXML()
        {
            try
            {
                Product product = new Product() { Id = 10, Name = "IPhone", Price = 1200 };
                XmlSerializer serializer = new XmlSerializer(typeof(Product));
                //StringWriter writer = new StringWriter();
                StreamWriter writer = new StreamWriter("products.xml");
                serializer.Serialize(writer, product);
                //Console.WriteLine(writer.ToString());
            }
            catch (Exception ex)
            {

                Console.WriteLine(ex.Message);
            }
        }

        static void GenerateProductJSON()
        {
            try
            {
                Product product = new Product() { Id = 10, Name = "IPhone", Price = 1200 };
                var json = JsonConvert.SerializeObject(product);
                Console.WriteLine(json);
                using (StreamWriter writer = new StreamWriter("Product.json"))
                {
                    writer.WriteLine(json);
                    writer.Flush();
                }

            }
            catch (Exception ex)
            {

                Console.WriteLine(ex.Message);
            }
        }
    }
}