using System;

namespace FilesStreams
{
    class Program
    {
        static void Main(string[] args)
        {
            MyFileHandler fileHandler = new MyFileHandler();

            //fileHandler.WriteContentToFile(Console.ReadLine());
            //fileHandler.ReadAllContent();
            fileHandler.UpperCaseContent("testfile3.txt", "testfile1.txt");
        }
    }
}
