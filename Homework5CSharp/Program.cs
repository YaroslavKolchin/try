using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace Homework5CSharp
{
    class Program
    {

        static void Main(string[] args)
        {
            testArrayLength();

        }
        static void testLink()
        {
            try
            {
                WebRequest request = WebRequest.Create("https://www.asdasd.ru");
                using (WebResponse response = request.GetResponse())
                {
                    using (Stream stream = response.GetResponseStream())
                    {
                        using (StreamReader reader = new StreamReader(stream))
                        {
                            Console.WriteLine(reader.ReadToEnd());
                        }
                    }
                }
            }
            catch (WebException ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                Console.WriteLine("Обработка запроса завершена");
            }
        }
        static void testArrayLength()
        {
            int[] arr = new int[10];
            Random rnd = new Random();
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = rnd.Next(1, 20);
            }
            try
            {

                arr[12] = 3;
                for (int j = 0; j < arr.Length + 1; j++)
                {
                    arr[j] += 2;
                }
            }
            catch (IndexOutOfRangeException ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                Console.WriteLine("Обработка массива завершена");
            }
        }       
    }
}
