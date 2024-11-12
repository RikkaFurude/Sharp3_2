
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sharp3_2
{
    internal class Files
    {
        
            //4
            public static void FillBin(string Input, int size)
            {
                Random random = new Random();
                using (BinaryWriter writer = new BinaryWriter(File.Open(Input, FileMode.Create)))
                {
                    for (int i = 0; i < size; i++)
                    {
                        int randomNumber = random.Next(1, 100);
                        writer.Write(randomNumber);
                    }
                }
            }
            public static void InsBin(string Input, string Output, int m, int n)
            {
                using (BinaryReader reader = new BinaryReader(File.Open(Input, FileMode.Open)))
                using (BinaryWriter writer = new BinaryWriter(File.Open(Output, FileMode.Create)))
                {
                    while (reader.BaseStream.Position < reader.BaseStream.Length)
                    {
                        int k = reader.ReadInt32();
                        if (k % m == 0 && k % n != 0)
                        {
                            writer.Write(k);
                        }
                    }
                }
            }
            public static void ShowBin(string Input)
            {
                using (BinaryReader reader = new BinaryReader(File.Open(Input, FileMode.Open)))
                {
                    while (reader.BaseStream.Position < reader.BaseStream.Length)
                    {
                        int number = reader.ReadInt32();
                        Console.Write(number + " ");
                    }
                }
                Console.WriteLine();
            }
            //5
            public static void FillBin2(string filePath)
            {
                Random random = new Random();
                string[] baggageNames = { "Чемодан", "Сумка", "Рюкзак", "Другое" };

                using (BinaryWriter writer = new BinaryWriter(File.Open(filePath, FileMode.Create)))
                {
                    int passengers = 15;

                    for (int i = 0; i < passengers; i++)
                    {
                        int baggageCount = random.Next(1, 4);
                        writer.Write(baggageCount);
                        for (int j = 0; j < baggageCount; j++)
                        {
                            Baggage baggage = new Baggage(
                                baggageNames[random.Next(baggageNames.Length)],
                                random.NextDouble() * 20
                            );
                            writer.Write(baggage.Name);
                            writer.Write(baggage.Weight);
                        }
                    }
                }
            }

            public static bool Check(string filePath, double m)
            {
                bool q = false;
                using (BinaryReader reader = new BinaryReader(File.Open(filePath, FileMode.Open)))
                {
                    while (reader.BaseStream.Position < reader.BaseStream.Length)
                    {
                        int baggageCount = reader.ReadInt32();

                        if (baggageCount == 1)
                        {
                            Baggage baggage = new Baggage
                            {
                                Name = reader.ReadString(),
                                Weight = reader.ReadDouble()
                            };


                            if (baggage.Weight < m)
                            {
                                Console.Write(baggageCount + " ");
                                Console.Write(baggage.Name + " ");
                                Console.WriteLine(baggage.Weight);
                                q = true;
                            }
                        }
                        else
                        {
                            for (int i = 0; i < baggageCount; i++)
                            {
                                reader.ReadString();
                                reader.ReadDouble();
                            }
                        }
                    }
                }
                return q;
            }
            //6
            public static void WriteText(string path)
            {
                Random random = new Random();
                StreamWriter sw = new StreamWriter(path);
                for (int i = 0; i < 20; i++)
                {
                    int randomnumber = random.Next(0, 130);
                    sw.WriteLine(randomnumber);

                }
                sw.Close();
            }
            public static int ReadText(string path)
            {
                Random random = new Random();
                StreamReader sr = new StreamReader(path);
                string line = sr.ReadLine();
                int max = -9999;
                int min = 9999;
                while (line != null)
                {
                    int sth = Convert.ToInt32(line);
                    if (sth < min) min = sth;
                    if (sth > max) max = sth;
                    line = sr.ReadLine();
                }
                sr.Close();
                return max - min;
            }
            //7
            public static void WriteText2(string path)
            {
                Random random = new Random();
                StreamWriter sw = new StreamWriter(path);
                for (int i = 0; i < 10; i++)
                {
                    int randomnumber = random.Next(-130, 130);
                    int randomnumber2 = random.Next(-130, 130);
                    int randomnumber3 = random.Next(-130, 130);
                    sw.WriteLine(randomnumber + " " + randomnumber2 + " " + randomnumber3);

                }
                sw.Close();
            }
            public static int ReadText2(string path)
            {
                StreamReader sr = new StreamReader(path);
                string line = sr.ReadLine();
                int min = 131;
                while (line != null)
                {
                    int i = 0;
                    int num;
                    string s = "";
                    while (i < line.Length)
                    {
                        if (line[i] == ' ')
                        {
                            num = Convert.ToInt32(s);
                            if (num < min) min = num;
                            s = "";
                        }
                        else
                        {
                            s += line[i];
                        }
                        i++;
                    }
                    num = Convert.ToInt32(s);
                    if (num < min) min = num;
                    line = sr.ReadLine();
                }
                sr.Close();
                return min;
            }

            //8
            public static void WriteText3(string path)
            {
                StreamWriter sw = new StreamWriter(path);
                string s = "";
                while (s != "0")
                {
                    s = Console.ReadLine();
                    sw.WriteLine(s);
                }
                sw.Close();
            }
            public static void WriteText4(string In, string Out, char q)
            {
                StreamWriter sw = new StreamWriter(Out);
                StreamReader sr = new StreamReader(In);
                string line = sr.ReadLine();
                while (line != "0")
                {
                    if (line[0] == q)
                    {
                        sw.WriteLine(line);
                    }
                    line = sr.ReadLine();
                }
                sw.Close();
            }
    }//

}
