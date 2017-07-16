using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FocusStartDylgyrzhapovBuin
{
    class Program
    {
        static void Main(string[] args)
        {
            if (args.Length != 4)
            {
                Console.WriteLine("Not enough args");
                return;
            }
            string InFile = args[0];
            string OutFile = args[1];
            string Type = args[2];
            string Flag = args[3];
            Base exp;
            switch (Type)
            {
                case "-s":
                    exp = new StringLines();
                    break;
                case "-i":
                    exp = new NumberLines();
                    break;
                default:
                    Console.WriteLine("Wrong Type");
                    return;
            }
            if (Flag != "-a" && Flag != "-d")
            {
                Console.WriteLine("Wrong Flag");
                return;
            }
            try
            {
                using (StreamReader sr = new StreamReader(File.Open(InFile, FileMode.Open)))
                {
                    try
                    {
                        while (!sr.EndOfStream)
                            exp.Add(sr.ReadLine());
                    }
                    catch(Exception ex)
                    {
                        Console.WriteLine("Wrong input type");
                    }
                }
            }
            catch(FileNotFoundException ex)
            {
                Console.WriteLine("File not found");
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex);
            }
            exp.Sort(Flag);
            exp.Write(OutFile);
            Console.WriteLine("Success");
        }
    }
}
