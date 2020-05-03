using System;
using System.Threading;
using Math;
using Microsoft.VisualBasic;

namespace Math
{
    class Program
    {
        static void Main(string[] args)
        {
            bool start;
            
            Console.WriteLine("Ali želiš vžgati program? (y/n)");
            string začetek = Console.ReadLine();

            while (start = true)
            {
            
            //izbiranje operatorja
            Console.WriteLine("Matematika se pripravlja...");
            Console.WriteLine("Lahko uporabiš decimalke in ob tem tudi naravna št.");
            Console.WriteLine("Katero vrsto operacij želiš uporabiti(Množenje, deljenje, plus, minus, koren)?");
            string input = Console.ReadLine();

            //zmnožek method
            static double zmnožek(double x, double y)
            {
                return x * y;
            }

            //plus method
            static double plus(double x, double y)
            {
                return x + y;
            }

            //minus method
            static double minus(double x, double y)
            {
                return x - y;
            }

            //deljenje method
            static double deljenje(double x , double y)
            {
                return x / y;
            }

            static float koren(float x)
            {
                    return MathF.Sqrt(x);

            }



                if (input == "Množenje" || input == "množenje" || input == "x" || input == "X" || input == "multiplication" || input == "MULTIPLICATION" || input == "MNOŽENJE" || input == "Multiplication" || input == "Zmnožek" || input == "zmnožek" || input == "ZMNOŽEK")
                {
                    //množenje
                    Console.WriteLine("Vredu. Se pravi najprej napiši prvo številko (npr. 1 ali 15,2 ali 5,22)");
                    //input prve za zmnožek
                    double prva_zmnožek = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("Vredu. Pravkar si vpisal št. " + prva_zmnožek + ", zdaj pa še vpiši drugo št. (npr. " + prva_zmnožek + " x 10,0)");
                    //input druga za zmnožek
                    double druga_zmnožek = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("Rezultat je: " + zmnožek(prva_zmnožek, druga_zmnožek));
                    Console.WriteLine("Ali želiš še kaj zračunati?(y/n)");
                    string nadaljevanje_množenje = Console.ReadLine();

                    if (nadaljevanje_množenje=="y"||nadaljevanje_množenje=="Y"||nadaljevanje_množenje=="YES"||nadaljevanje_množenje=="yes"||nadaljevanje_množenje=="Yes"||nadaljevanje_množenje=="Ja"||nadaljevanje_množenje=="ja"||nadaljevanje_množenje=="JA")
                    {
                        Console.WriteLine("Vredu.");
                        continue;
                    }

                    else if (nadaljevanje_množenje=="N"||nadaljevanje_množenje=="n"||nadaljevanje_množenje=="NE"||nadaljevanje_množenje=="ne"||nadaljevanje_množenje=="Ne"||nadaljevanje_množenje=="No"||nadaljevanje_množenje=="NO"||nadaljevanje_množenje=="no")
                    {
                        Console.WriteLine("Vredu.");
                        break;
                    }

                    else
                    {
                        Console.WriteLine("Ne razumem. Pošiljam te v meni za izbiro matematičnih operacij.");
                        Console.WriteLine("Če tega ne želiš, potem napiši 'exit'.");
                        continue;
                    }
                }

                else if (input == "plus" || input == "PLUS" || input == "Plus" || input == "+")
                {
                    //plus

                    Console.WriteLine("Vredu. Se pravi napiši prvo št. (npr. 1,3 ali 5 ali 16,1)");
                    //input za prvi plus
                    double prva_plus = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("Vredu. Pravkar si vpisal št. " + prva_plus + ", zdaj pa še vpiši drugo št. (npr. " + prva_plus + " + 10,0.)");
                    //input za drugi plus
                    double druga_plus = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("Rezultat je: " + plus(prva_plus, druga_plus));
                }

                else if (input == "minus" || input == "MINUS" || input == "Minus" || input == "-")
                {
                    //minus
                    Console.WriteLine("Vredu. Se pravi najprej napiši prvo št. (npr. 1 ali 15,2 ali 5,33)");
                    //input za prvi minus
                    double prva_minus = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("Vredu. Pravkar si vpisal št. " + prva_minus + ", zdaj pa še vpiši drugo št. (npr. " + prva_minus + " - 10,0.)");
                    //input za drugi minus
                    double druga_minus = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("Rezultat je: " + minus(prva_minus, druga_minus));
                }

                else if (input == "Deljenje" || input == "DELJENJE" || input == "Deljenje" || input == "/")
                {
                    //Deljenje
                    Console.WriteLine("Vredu. Napiši prvo št. (npr. 1,3 ali 5 ali 16,1)");
                    //input za prvi količnik
                    double prva_deljenje = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("Vredu. Pravkar si vpisal št. " + prva_deljenje + ", zdaj pa še vpiši drugo št. (npr. " + prva_deljenje + " : 10,0)");
                    //input za drugi količnik
                    double druga_deljenje = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("Rezultat je: " + deljenje(prva_deljenje, druga_deljenje));
                    Console.WriteLine("Ali želiš še kaj zračunati?(y/n)");
                    string nadaljevanje_deljenje = Console.ReadLine();

                    if (nadaljevanje_deljenje=="y"||nadaljevanje_deljenje=="Y"||nadaljevanje_deljenje=="YES"||nadaljevanje_deljenje=="yes"||nadaljevanje_deljenje=="Yes"||nadaljevanje_deljenje=="Ja"||nadaljevanje_deljenje=="ja"||nadaljevanje_deljenje=="JA")
                    {
                        Console.WriteLine("Vredu.");
                        continue;
                    }
                }


                else if (input == "Koren" || input == "KOREN" || input == "koren" || input == "Square Root" || input == "SQRT" || input == "Sqrt" || input == "sqrt" || input == "square root" || input == "SQUARE ROOT")
                {
                    //koren
                    Console.WriteLine("Vredu. Napiši št., ki jo hočeš dati pod koren (npr. 1.3 ali 5 ali 16.1)");
                    //input za prva koren
                    float prva_koren = float.Parse(Console.ReadLine());
                    Console.WriteLine(prva_koren + " pod korenom je " + koren(prva_koren));
                    Console.WriteLine("Ali želiš še kaj zračunati?(y/n)");
                    string nadaljevanje_koren = Console.ReadLine();

                    if (nadaljevanje_koren == "y" || nadaljevanje_koren == "Y" || nadaljevanje_koren == "YES" || nadaljevanje_koren == "Yes" || nadaljevanje_koren == "yes" || nadaljevanje_koren == "ja" || nadaljevanje_koren == "JA" || nadaljevanje_koren == "Ja")
                    {
                        Console.WriteLine("V redu.");
                        continue;
                    }

                    else if (nadaljevanje_koren == "ne" || nadaljevanje_koren == "NE" || nadaljevanje_koren == "Ne" || nadaljevanje_koren == "n" || nadaljevanje_koren == "N" || nadaljevanje_koren == "NO" || nadaljevanje_koren == "No" || nadaljevanje_koren == "no")
                    {
                        Console.WriteLine("v redu.");
                        break;
                    }

                    else
                    {
                        Console.WriteLine("Ne razumem. Pošiljam te v meni za izbiro matematičnih operacij.");
                        Console.WriteLine("Če tega ne želiš, potem napiši v meniju 'exit'.");
                        continue;
                    }
                }
                else if (input == "exit" || input == "EXIT" || input == "Exit" || input == "Izhod" || input == "izhod" || input == "IZHOD")
                {

                }
           

            }

            if (začetek=="y"||začetek=="Y"||začetek=="YES"||začetek=="yes"||začetek=="Yes"||začetek=="Ja"||začetek=="JA"||začetek=="ja")
            {
                Console.WriteLine("Program se zaganja...");
                start = true;
            }

            else if (začetek=="N"||začetek=="n"||začetek=="No"||začetek=="NO"||začetek=="no"||začetek=="ne"||začetek=="NE"||začetek=="Ne")
            {
                Console.WriteLine("Vredu.");
                start = false;
            }

            else
            {
                Console.WriteLine("Ne razumem. Pošiljam te v meni za izbiro matematičnih operacij.");
                Console.WriteLine("Če tega ne želiš, potem napiši 'exit' pri izbiri matematičnih operacij.");
            }
            
           
           
            
           
            
            
           
        }
    }
}
