using System;
using System.IO;
using System.Text;

namespace Sharp3_2
{
    struct Baggage
    {
        public string Name;
        public double Weight;

        public Baggage(string name, double weight)
        {
            Name = name;
            Weight = weight;
        }
    }

    class Program
    {
        static void Main()
        {
            string DZ;
            Console.Write("Введите задание: ");
            DZ = Console.ReadLine();
            switch (DZ)
            {
                case ("4"):
                    string InputFile = "source4.bin";
                    string OutputFile = "result4.bin";
                    string s;
                    int size = 25;
                    Console.Write("Введите m: ");
                    s = Console.ReadLine();
                    int m;
                    try
                    {
                        m = Convert.ToInt32(s);
                    }
                    catch
                    {
                        Console.WriteLine("m Не является типом int");
                        throw;
                    }
                    Console.Write("Введите n: ");
                    s = Console.ReadLine();
                    int n;
                    try
                    {
                        n = Convert.ToInt32(s);
                    }
                    catch
                    {
                        Console.WriteLine("n Не является типом int");
                        throw;
                    }

                    Files.FillBin(InputFile, size);
                    Console.WriteLine("Содержимое исходного файла:");
                    Files.ShowBin(InputFile);

                    Files.InsBin(InputFile, OutputFile, m, n);

                    Console.WriteLine("Содержимое полученного файла:");
                    Files.ShowBin(OutputFile);
                    break;
                case ("5"):
                    string InputFile2 = "source5.bin";
                    Console.Write("Введите m: ");
                    s = Console.ReadLine();
                    double m2;
                    try
                    {
                        m2 = Convert.ToInt32(s);
                    }
                    catch
                    {
                        Console.WriteLine("m Не является типом int");
                        throw;
                    }
                    Files.FillBin2(InputFile2);
                    bool q = Files.Check(InputFile2, m2);
                    Console.WriteLine(q);
                    break;
                case ("6"):
                    string Input = "note1.txt";
                    Files.WriteText(Input);
                    int result = Files.ReadText(Input);
                    Console.WriteLine(result);
                    break;
                case ("7"):
                    string Input2 = "note1.txt";
                    Files.WriteText2(Input2);
                    int min = Files.ReadText2(Input2);
                    Console.WriteLine(min);
                    break;
                case ("8"):
                    string InputFile3 = "Input3.txt";
                    string OutputFile3 = "Output3.txt";
                    Console.Write("Введите символ m: ");

                    s = Console.ReadLine();
                    char zz;
                    try
                    {
                        zz = Convert.ToChar(s);
                    }
                    catch
                    {
                        Console.WriteLine("m Не является символом");
                        throw;
                    }
                    Files.WriteText3(InputFile3);
                    Files.WriteText4(InputFile3, OutputFile3, zz);
                    break;

            }
        }
    }
}