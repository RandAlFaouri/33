﻿using System;
using System.IO;
namespace CAFileStream
{
    internal class Program
    {

        private static void Main(string[] args)
        {
            //Example01();
            //Example02();
            // Example03();
            // Example04();
            //Example05();
            //Example06();
            // Example07();
            //Example08();
            //Example09();
            Example10();
            Console.ReadKey();
        }
        //private static void Main(string[] args)
        //{
        //    Example01();
        //    Console.ReadKey();
        //}
        //static void Example01()
        //{
        //    string path = @"C:\\Users\\LENOVO\\Desktop\\Training\\sample.txt";
        //    using (var fs = new FileStream(path, FileMode.Open, FileAccess.ReadWrite))
        //    {
        //        Console.WriteLine($"Length: {fs.Length} Byte(s)");
        //        Console.WriteLine($"CanRead: {fs.CanRead}");
        //        Console.WriteLine($"CanWrite: {fs.CanWrite} ");
        //        Console.WriteLine($"CanSeek: {fs.CanSeek}");
        //        Console.WriteLine($"CanTimeout: {fs.CanTimeout}");
        //        Console.WriteLine($"Position: {fs.Position}");
        //        fs.WriteByte(65); //A
        //        Console.WriteLine($"Position: {fs.Position}");
        //        fs.WriteByte(97); //a
        //        Console.WriteLine($"Position: {fs.Position}");
        //        fs.WriteByte(13); //Enter
        //        Console.WriteLine($"Position: {fs.Position}");
        //        for(byte i = 65; i < 123;i++)
        //        {
        //            fs.WriteByte(i);
        //        }

        //    } 
        //}
        /*   static void Example02()
           {
               string path = @"C:\\Users\\LENOVO\\Desktop\\Training\\sample.txt";
               using (var fs = new FileStream(path, FileMode.Open, FileAccess.ReadWrite))
               {
                   byte[] data = new byte[fs.Length];
                   int numBytesToRead = (int)fs.Length;
                   int numBytesRead = 0;
                   while (numBytesToRead > 0)
                   {
                       int n = fs.Read(data, numBytesRead, numBytesToRead);
                       if (n == 0)
                           break;
                       numBytesToRead -= n;
                       numBytesRead += n;
                   }
                   foreach (byte b in data)
                   {
                       Console.Write(b);
                   }
                   var newPath = @"C:\\Users\\LENOVO\\Desktop\\Training\\sample1.txt";
                   using (var fsw = new FileStream(newPath, FileMode.OpenOrCreate, FileAccess.ReadWrite))
                   {
                       fsw.Write(data, 0, data.Length);
                   }
               }
           }*/
        /*  static void Example03()
          {
              string path = @"C:\\Users\\LENOVO\\Desktop\\Training\\sample2.txt";
              using (var fs = new FileStream(path, FileMode.OpenOrCreate, FileAccess.ReadWrite))
              {
                  fs.Seek(20,SeekOrigin.Begin);
                  fs.WriteByte(65);
                  fs.Position = 0;
                  for (int i = 0; i < fs.Length; i++)
                  {
                      Console.WriteLine(fs.ReadByte());
                  }

              }
          }*/
        static void Example04()
        {
            String path = @"C:\\Users\\LENOVO\\Desktop\\Training\\sample3.txt";
            using (var sw = new StreamWriter(path))
            {
                sw.WriteLine("This");
                sw.WriteLine("Is");
                sw.WriteLine("C#");
                
            }
            
           

            
        }
        static void Example05()
        {
            String path = @"C:\\Users\\LENOVO\\Desktop\\Training\\sample3.txt";
            using (var sr = new StreamReader(path))
            {
               while (sr.Peek()>0)
                {
                    Console.Write((char)sr.Read());
                }
                
            }




        }
        static void Example06()
        {
            String path = @"C:\\Users\\LENOVO\\Desktop\\Training\\sample3.txt";
            using (var sr = new StreamReader(path))
            {
                string line;
                while ((line=sr.ReadLine())is not null ) //!= null

                {
                    Console.WriteLine(line);
                }

            }




        }
        static void Example07()
        {
            String path = @"C:\\Users\\LENOVO\\Desktop\\Training\\sample4.txt";
            string[] lines =
            {
                "C#",
                "Is",
                "Amazing",
                "Language"
            };
            File.WriteAllLines(path, lines);
            

            




        }
        static void Example08()
        {
            String path = @"C:\\Users\\LENOVO\\Desktop\\Training\\sample5.txt";
            string text = "C# Is Amazing Language";
            
            File.WriteAllText(path, text);







        }
        static void Example09()
        {
            String path = @"C:\\Users\\LENOVO\\Desktop\\Training\\sample5.txt";
            

           var result = File.ReadAllText(path);
            Console.WriteLine(result);







        }
        static void Example10()
        {
            String path = @"C:\\Users\\LENOVO\\Desktop\\Training\\sample4.txt";


            var lines = File.ReadAllLines(path);
            Console.WriteLine(lines );
            foreach ( var line in lines)
            {

            Console.WriteLine(line); }







        }
    }
}