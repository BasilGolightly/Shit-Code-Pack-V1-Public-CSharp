using System;
using System.Reflection.Metadata.Ecma335;
using System.Security.Cryptography.X509Certificates;

namespace Conversion
{
    class Program
    {
        static void Main(string[] args)
        {
            static double lbstokg(double x)
            {
                return x * 0.45359237;
            }
            
            static double mtoft(double x)
            {
                return x * 3.2808399;
            }

            static double cmtoinch(double x)
            {
                return x * 0.393700787;
            }

            static double kgtolbs(double x)
            {
                return x / 0.45359237;
            }

            static double inchtocm(double x)
            {
                return x * 2.54;
            }

            static double fttom(double x)
            {
                return x / 3.2808399;
            }
            
            bool start;
            Console.WriteLine("Ali hočeš vžgati program za pretvorbe?(y/n)");
            string program_input = Console.ReadLine();
            //input za začetek
            
            if (program_input == "y" || program_input == "Y"|| program_input == "Yes"|| program_input=="da"||program_input=="DA"||program_input =="Da"|| program_input== "YES"|| program_input == "yes"||program_input == "ja"|| program_input == "Ja")
            {
                   
                start = true;
                   
                   while (start == true)
                   {
                       //izbira pretvorbe 
                       Console.WriteLine("Kaj želiš pretvoriti? Izberi/napiši eno od naslednjega: lbs do kg, meter do ft, cm do inch (ali obratno).");
                       Console.WriteLine("Če ne želiš uporabiti programa, napiši 'exit'.");
                       string izbira_pretvorbe = Console.ReadLine();

                    if (izbira_pretvorbe == "lbs do kg " || izbira_pretvorbe == "LBS DO KG" || izbira_pretvorbe == "Lbs do Kg" || izbira_pretvorbe == "lbs to kg" || izbira_pretvorbe == "LBS TO KG" || izbira_pretvorbe == "Lbs to Kg")
                    {

                        // input prve št. (lbs to pounds)
                        Console.WriteLine("V redu. Vpiši št. lbs (pounds):");
                        double prva_lbskg = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine(prva_lbskg + " lbs = " + lbstokg(prva_lbskg));
                        //nadaljevanje input
                        Console.WriteLine("Ali želiš še kaj pretvoriti?(y/n)");
                        string nadaljevanje_lbskg = Console.ReadLine();

                        if (nadaljevanje_lbskg == "Y" || nadaljevanje_lbskg == "y" || nadaljevanje_lbskg == "Ja" || nadaljevanje_lbskg == "JA" || nadaljevanje_lbskg == "ja" || nadaljevanje_lbskg == "Yes" || nadaljevanje_lbskg == "YES" || nadaljevanje_lbskg == "yes")
                        {
                            Console.WriteLine("Vredu.");
                            continue;
                        }

                        else if (nadaljevanje_lbskg == "N" || nadaljevanje_lbskg == "n" || nadaljevanje_lbskg == "Ja" || nadaljevanje_lbskg == "JA" || nadaljevanje_lbskg == "ja" || nadaljevanje_lbskg == "yes" || nadaljevanje_lbskg == "YES" || nadaljevanje_lbskg == "Yes")
                        {
                            Console.WriteLine("V redu. Hvala za uporabo tega programa!");
                            break;
                        }
                        else
                        {
                            Console.WriteLine("Ne razumem. Vseeno je.");
                            Console.WriteLine("Če želiš iti ven iz programa napiši 'exit'");
                            continue;
                        }
                    }

                    //exit
                    else if (izbira_pretvorbe == "Exit" || izbira_pretvorbe == "EXIT" || izbira_pretvorbe == "exit")
                    {
                        Console.WriteLine("V redu.");
                        break;
                    }

                    //meter to feet
                    else if (izbira_pretvorbe == "Meter to Feet" || izbira_pretvorbe == "METER to FEET" || izbira_pretvorbe == "meter to feet" || izbira_pretvorbe == "meter do feet" || izbira_pretvorbe == "METER DO FEET" || izbira_pretvorbe == "Meter do Feet" || izbira_pretvorbe == "m to ft" || izbira_pretvorbe == "m do ft" || izbira_pretvorbe == "M TO FT")
                    {
                        Console.WriteLine("V redu. Napiši št. metrov.");
                        double prva_mtoft = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine(prva_mtoft + " m = " + mtoft(prva_mtoft) + " ft.");
                        Console.WriteLine("Ali želiš še kaj pretvoriti (y/n)");
                        string nadaljevanje_mtoft = Console.ReadLine();

                        if (nadaljevanje_mtoft == "y" || nadaljevanje_mtoft == "Y" || nadaljevanje_mtoft == "YES" || nadaljevanje_mtoft == "Yes" || nadaljevanje_mtoft == "yes" || nadaljevanje_mtoft == "Ja" || nadaljevanje_mtoft == "ja")
                        {
                            Console.WriteLine("Vredu.");
                            continue;
                        }

                        else if (nadaljevanje_mtoft == "n" || nadaljevanje_mtoft == "N" || nadaljevanje_mtoft == "No" || nadaljevanje_mtoft == "no" || nadaljevanje_mtoft == "NO" || nadaljevanje_mtoft == "Ne" || nadaljevanje_mtoft == "ne" || nadaljevanje_mtoft == "NE")
                        {
                            Console.WriteLine("V redu.");
                            break;
                        }

                        else
                        {
                            Console.WriteLine("Ne razumem. Bom te kar dal v meni za izbiro pretvorb");
                            Console.WriteLine("Če ne želiš potem pri izbiri napiši 'exit'.");
                        }


                    }

                    //cm to inch
                    else if (izbira_pretvorbe == "cm do inch" || izbira_pretvorbe == "CM DO INCH" || izbira_pretvorbe == "Cm Do Inch" || izbira_pretvorbe == "cm to inch" || izbira_pretvorbe == "CM TO INCH" || izbira_pretvorbe == "Cm To Inch")
                    {
                        Console.WriteLine("V redu. Napiši št. cm");
                        double prva_cmtoinch = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine(program_input + " cm = " + cmtoinch(prva_cmtoinch) + " inch.");
                        Console.WriteLine("Ali želiš še kaj pretvoriti(y/n)");
                        string nadaljevanje_cmtoinch = Console.ReadLine();

                        if (nadaljevanje_cmtoinch == "Y" || nadaljevanje_cmtoinch == "y" || nadaljevanje_cmtoinch == "YES" || nadaljevanje_cmtoinch == "Yes" || nadaljevanje_cmtoinch == "yes" || nadaljevanje_cmtoinch == "Ja" || nadaljevanje_cmtoinch == "ja" || nadaljevanje_cmtoinch == "JA")
                        {
                            Console.WriteLine("V redu.");
                            continue;
                        }

                        else if (nadaljevanje_cmtoinch == "NO" || nadaljevanje_cmtoinch == "No" || nadaljevanje_cmtoinch == "no" || nadaljevanje_cmtoinch == "n" || nadaljevanje_cmtoinch == "N" || nadaljevanje_cmtoinch == "Ne" || nadaljevanje_cmtoinch == "NE" || nadaljevanje_cmtoinch == "ne")
                        {
                            Console.WriteLine("V redu.");
                            break;
                        }

                    }

                    //kg to lbs
                    else if (izbira_pretvorbe == "Kg to Lbs" || izbira_pretvorbe == "KG TO LBS" || izbira_pretvorbe == "kg to lbs" || izbira_pretvorbe == "kg do lbs" || izbira_pretvorbe == "KG DO LBS" || izbira_pretvorbe == "Kg do Lbs")
                    {
                        Console.WriteLine("V redu. Vpiši št. kg");
                        double prva_kgtolbs = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine(prva_kgtolbs + " kg = " + kgtolbs(prva_kgtolbs) + " lbs.");
                        Console.WriteLine("Ali želiš še kaj pretvoriti? (y/n)");
                        string nadaljevanje_kgtolbs = Console.ReadLine();

                        if (nadaljevanje_kgtolbs == "Y" || nadaljevanje_kgtolbs == "y" || nadaljevanje_kgtolbs == "YES" || nadaljevanje_kgtolbs == "Yes" || nadaljevanje_kgtolbs == "yes" || nadaljevanje_kgtolbs == "ja" || nadaljevanje_kgtolbs == "JA" || nadaljevanje_kgtolbs == "Ja")
                        {
                            Console.WriteLine("V redu.");
                            continue;
                        }

                        else if (nadaljevanje_kgtolbs=="N"||nadaljevanje_kgtolbs=="n"||nadaljevanje_kgtolbs=="Ne"||nadaljevanje_kgtolbs=="NE"||nadaljevanje_kgtolbs=="ne"||nadaljevanje_kgtolbs=="No"||nadaljevanje_kgtolbs=="NO"||nadaljevanje_kgtolbs=="no")
                        {
                            Console.WriteLine("V redu.");
                            break;
                        }

                        else
                        {
                            Console.WriteLine("Ne razumem. Pošiljam te v meni za izbiro pretvorb.");
                            Console.WriteLine("Če tega ne želiš, napiši 'exit' pri izbiri za pretvorbe.");
                            continue;
                        }
                    
                    }

                    //inch to cm
                    else if (izbira_pretvorbe=="inch to cm"||izbira_pretvorbe=="INCH TO CM"||izbira_pretvorbe=="Inch To Cm"||izbira_pretvorbe=="Inch to Cm"||izbira_pretvorbe=="inch do cm"||izbira_pretvorbe=="Inch do Cm"||izbira_pretvorbe=="INCH DO CM"||izbira_pretvorbe=="Inch Do Cm")
                    {
                        Console.WriteLine("V redu. Vpiši št. inch.");
                        double prva_inchtocm = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine(program_input + " inch = " + inchtocm(prva_inchtocm) + " cm.");
                        Console.WriteLine("Ali želiš še kaj pretvoriti? (y/n)");
                        string nadaljevanje_inchtocm = Console.ReadLine();

                        if (nadaljevanje_inchtocm=="y"||nadaljevanje_inchtocm=="Y"||nadaljevanje_inchtocm=="YES"||nadaljevanje_inchtocm=="Yes"||nadaljevanje_inchtocm=="yes"||nadaljevanje_inchtocm=="Ja"||nadaljevanje_inchtocm=="JA"||nadaljevanje_inchtocm=="ja")
                        {
                            Console.WriteLine("V redu.");
                            continue;

                        }

                        else if (nadaljevanje_inchtocm == "N"||nadaljevanje_inchtocm=="n"||nadaljevanje_inchtocm=="No"||nadaljevanje_inchtocm=="NO"||nadaljevanje_inchtocm=="no"||nadaljevanje_inchtocm=="Ne"||nadaljevanje_inchtocm=="NE"||nadaljevanje_inchtocm=="ne")
                        {
                            Console.WriteLine("V redu.");
                            break;
                        }

                        else
                        {
                            Console.WriteLine("Ne razumem. Poslal te bom v meni za izbiro pretvorb.");
                            Console.WriteLine("Če tega ne želiš, napiši pri ibiri 'exit', kar te bo vrglo ven iz programa.");
                            continue;
                        }
                    }

                    //ft to m
                    else if (izbira_pretvorbe=="feet to meter"||izbira_pretvorbe=="Feet to Meter"||izbira_pretvorbe=="FEET TO METER"||izbira_pretvorbe=="ft to m"||izbira_pretvorbe=="FT TO M"||izbira_pretvorbe=="Ft to M"||izbira_pretvorbe=="Ft do M"||izbira_pretvorbe=="ft do m"||izbira_pretvorbe=="FT DO M"||izbira_pretvorbe=="Feet do Meter"||izbira_pretvorbe=="feet do meter"||izbira_pretvorbe=="FEET DO METER")
                    {
                        Console.WriteLine("V redu. Napiši št. ft");
                        double prva_fttom = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine(prva_fttom + " ft = "  + fttom(prva_fttom) + " m");
                        Console.WriteLine("Ali želiš še kaj pretvoriti?");
                        string nadaljevanje_fttom = Console.ReadLine();

                        if (nadaljevanje_fttom=="y"||nadaljevanje_fttom=="Y"||nadaljevanje_fttom=="Yes"||nadaljevanje_fttom=="yes"||nadaljevanje_fttom=="YES"||nadaljevanje_fttom=="Ja"||nadaljevanje_fttom=="JA"||nadaljevanje_fttom=="ja")
                        {
                            Console.WriteLine("V redu.");
                            continue;
                        }

                        else if (nadaljevanje_fttom=="N"||nadaljevanje_fttom=="n"||nadaljevanje_fttom=="NO"||nadaljevanje_fttom=="no"||nadaljevanje_fttom=="No"||nadaljevanje_fttom=="Ne"||nadaljevanje_fttom=="NE"||nadaljevanje_fttom=="ne")
                        {
                            Console.WriteLine("V redu.");
                            break;
                        }

                        else
                        {
                            Console.WriteLine("Ne razumem. Pošiljam te v meni za izbiro pretvorb.");
                            Console.WriteLine("Če tega ne želiš, napiši 'exit', ko izbiraš pretvorbe.");
                            continue;
                        }
                        
                    }
                     
                   }     
            }       
                        
            // zavrni igro
            else if (program_input == "N"||program_input=="n"||program_input=="No"||program_input=="NO"||program_input=="no"||program_input=="Ne"|| program_input=="NE"||program_input=="ne")
            {
                start = false;
            }
            
            //exit
            else if (program_input == "Exit"|| program_input=="exit"|| program_input=="EXIT")
            {
                start = false;
                Console.WriteLine("V redu.");
            }    
            

            // nerazumljiv input
            else
            {
                Console.WriteLine("Ne razumem. Pošiljam te v meni za izbiro pretvorb.");
                start = true;
            }                              
                    
        }    
                    
    }
     
}            

           
           

            
        
