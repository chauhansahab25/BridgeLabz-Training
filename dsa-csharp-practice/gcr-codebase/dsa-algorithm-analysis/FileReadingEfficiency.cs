using System;
using System.Diagnostics;
using System.IO;
using System.Text;

namespace CG_Practice.dsacsharp
{
    class FileReadingEfficiency
    {
        static void Main(string[] args)
        {
            int[] fileSizes = { 1, 10, 50 };
            
            Console.WriteLine("File Size\tStreamReader\tFileStream");
            Console.WriteLine("-----------------------------------------------");
            
            foreach (int sizeMB in fileSizes)
            {
                string fileName = $"testfile_{sizeMB}MB.txt";
                CreateTestFile(fileName, sizeMB);
                
                Stopwatch sw = Stopwatch.StartNew();
                ReadWithStreamReader(fileName);
                sw.Stop();
                double streamReaderTime = sw.Elapsed.TotalMilliseconds;
                
                sw.Restart();
                ReadWithFileStream(fileName);
                sw.Stop();
                double fileStreamTime = sw.Elapsed.TotalMilliseconds;
                
                Console.WriteLine($"{sizeMB}MB\t\t{streamReaderTime:F2}ms\t\t{fileStreamTime:F2}ms");
                
                File.Delete(fileName);
            }
        }
        
        static void CreateTestFile(string fileName, int sizeMB)
        {
            using (FileStream fs = new FileStream(fileName, FileMode.Create))
            {
                byte[] data = Encoding.UTF8.GetBytes("This is test data for file reading performance comparison.\n");
                int iterations = (sizeMB * 1024 * 1024) / data.Length;
                
                for (int i = 0; i < iterations; i++)
                    fs.Write(data, 0, data.Length);
            }
        }
        
        static void ReadWithStreamReader(string fileName)
        {
            using (StreamReader sr = new StreamReader(fileName))
            {
                while (!sr.EndOfStream)
                    sr.ReadLine();
            }
        }
        
        static void ReadWithFileStream(string fileName)
        {
            using (FileStream fs = new FileStream(fileName, FileMode.Open))
            {
                byte[] buffer = new byte[4096];
                while (fs.Read(buffer, 0, buffer.Length) > 0)
                {
                }
            }
        }
    }
}
