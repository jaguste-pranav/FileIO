﻿using System;
using System.IO;

namespace FileIODemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to File I/O Operation");
            FileExits();
            ReadAllLines();
            Console.Write("\n\n");
            ReadAllText();

            ReadFromStreamReader();
            WriteUsingStreamWriter();
            ReadFromStreamReader();
        }
        public static void FileExits()
        {
            string path = @"C:\Users\Pranav V Jaguste\source\repos\FileIO\FileIO\Sample.txt";
            if (File.Exists(path))
            {
                Console.WriteLine("File Exists");
            }
            else
            {
                Console.WriteLine("File Does Not Exists");
            }
        }
        public static void ReadAllLines()
        {
            string path = @"C:\Users\Pranav V Jaguste\source\repos\FileIO\FileIO\Sample.txt";
            string[] lines;
            lines = File.ReadAllLines(path);

            Console.WriteLine(lines[0]);
            Console.WriteLine(lines[1]);
        }
        public static void ReadAllText()
        {
            string path = @"C:\Users\Pranav V Jaguste\source\repos\FileIO\FileIO\Sample.txt";
            string lines;
            lines = File.ReadAllText(path);
            Console.WriteLine(lines);
        }
        public static void MakeCopy()
        {
            string path = @"C:\Users\Pranav V Jaguste\source\repos\FileIO\FileIO\Sample.txt";
            string newPath = @"C:\Users\Pranav V Jaguste\source\repos\FileIO\FileIO\Sample.txt";
            File.Copy(path, newPath);

        }
        public static void Delete()
        {
            string newPath = @"C:\Users\Pranav V Jaguste\source\repos\FileIO\FileIO\Sample.txt";
            if (File.Exists(newPath))
            {
                File.Delete(newPath);
            }
        }
        public static void ReadFromStreamReader()
        {
            string path = @"C:\Users\Pranav V Jaguste\source\repos\FileIO\FileIO\Sample.txt";
            using (StreamReader sr = File.OpenText(path))
            {
                string s = "";
                while ((s = sr.ReadLine()) != null)
                {
                    Console.WriteLine(s);
                }
            }
        }
        public static void WriteUsingStreamWriter()
        {
            string path = @"C:\Users\Pranav V Jaguste\source\repos\FileIO\FileIO\Sample.txt";
            using (StreamWriter sr = File.AppendText(path))
            {
                sr.WriteLine("Hello world .Net is awesome");
                sr.Close();

                Console.WriteLine(File.ReadAllText(path));
            }

        }
    }
}