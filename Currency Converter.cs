using System;
using System.Reflection.Metadata.Ecma335;
using System.Security.Claims;

namespace Currency_Converter
{
    class Program
    {
        static void Main(string[] args)
        {
            //Methods

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

            //Euro to dollar method
            static double euro_todollar(double x)
            {
                return x * 1.08;
            }

            //Euro to yen method
            static double euro_toyen(double x)
            {
                return x * 115.82;
            }

            //Euro to ruble method
            static double euro_toruble(double x)
            {
                return x * 78.90;
            }

            //Euro to pound method
            static double euro_topound(double x)
            {
                return x * 0.89;
            }

            //Dollar to euro method
            static double dollar_toeuro(double x)
            {
                return x * 0.92;
            }

            //Dollar to yen method
            static double dollar_toyen(double x)
            {
                return x * 107.49;
            }

            //Dollar to ruble method
            static double dollar_toruble(double x)
            {
                return x * 72.74;
            }
            
            //Dollar to pound method
            static double dollar_topound(double x)
            {
                return x * 0.82;
            }

            //Yen to euro method
            static double yen_toeuro(double x)
            {
                return x * 0.0085;
            }

            //Yen to dolllar method
            static double yen_todollar(double x)
            {
                return x * 0.0093;
            }

            //Yen to ruble method
            static double yen_toruble(double x)
            {
                return x * 0.67;
            }

            //Yen to pound(GBP) method
            static double yen_topound(double x)
            {
                return x * 0.0076;
            }

            //Ruble to euro method
            static double ruble_toeuro(double x)
            {
                return x * 0.013;
            }

            //Ruble to dollar method
            static double ruble_todollar(double x)
            {
                return x * 0.014;
            }

            //Ruble to yen method
            static double ruble_toyen(double x)
            {
                return x * 1.50;
            }

            //Ruble to pound method
            static double ruble_topound(double x)
            {
                return x * 0.011;
            }

            //Pound to euro method
            static double pound_toeuro(double x)
            {
                return x * 1.12;
            }

            //Pound to dollar method
            static double pound_todollar(double x)
            {
                return x * 1.22;
            }

            //Pound to yen method
            static double pound_toyen(double x)
            {
                return x * 131.02;
            }

            //Pound to ruble method
            static double pound_toruble(double x)
            {
                return x * 87.15;
            }

            //Methods end
            
            //Program start 
            Console.WriteLine("Do you want to open the conversion program 2.0? (y/n)");
            //Program start input
            string program = Console.ReadLine();
            bool program_start;

            //Program start input is yes    
            if(program=="yes"||program=="YES"||program=="Yes"||program=="YeS"||program=="yEs"||program=="Ja"||program=="ja"||program=="JA"||program=="jA"||program=="y"||program=="Y")
            {
                program_start = true;
            }

            //Program start input is no
            else if (program == "no"||program == "NO"|| program =="No"||program=="nO"||program=="ne"||program=="NE"||program=="Ne"||program=="nE"||program=="n"||program=="N")
            {
                Console.WriteLine("Ok, have a nice day =)");
                program_start = false;
            }

            //Program start input not understood
            else
            {
                Console.WriteLine("I don't understand the input you just gave me.");
                Console.WriteLine("I will take the input as a yes.");
                program_start = true;
            }

            //while loop (currency converter main)
            while (program_start)
            {
                //Currency 1 selector
                Console.WriteLine("Which currency do you want to convert (Euro, $, USD - Dollar, Yen, Ruble, GBP - Pound)");
                Console.WriteLine("FYI: you can type 'exit' at any point in the program if you want to shut down the program or you can type 'reset' to get back to this menu.");
                string currency1 = Console.ReadLine();

                //Currency 1 is euro (€) 
                if (currency1 == "€"||currency1 == "euro"|| currency1 == "EURO" || currency1 == "Euro" || currency1 == "EUR"|| currency1 == "eUrO")
                {
                    Console.WriteLine("You have chosen Euro.");
                    Console.WriteLine("How many Euro/s do you have?");
                    
                    //Euro amount input
                    double euro_amount = double.Parse (Console.ReadLine());
                    Console.WriteLine("So you have " + euro_amount + " Euro/s");
                    Console.WriteLine("Into which currency do you want to convert these Euro/s? ($ - Dollar, Yen, ₽ - Ruble, Pound)");
                    
                    //Euro to currency 2 input
                    string euro_currency2 = Console.ReadLine();

                    //Euro to dollar
                    if (euro_currency2=="Dollar"||euro_currency2=="DOLLAR"||euro_currency2 == "dollar"||euro_currency2=="$"||euro_currency2=="Buck"||euro_currency2=="BUCK"||euro_currency2=="buck")
                    {
                        Console.WriteLine(euro_amount + " Euro/s = " + euro_todollar(euro_amount) + " Dollar/s");
                        Console.WriteLine("Do you want to convert anything else(y/n)?");
                        //Euro to dollar continuation input
                        string euro_dollarnext = Console.ReadLine();

                        //Euro to dollar continuation input is yes
                        if (euro_dollarnext=="yes"||euro_dollarnext=="YES"||euro_dollarnext=="Yes"||euro_dollarnext=="yES"||euro_dollarnext=="y"||euro_dollarnext=="Y"||euro_dollarnext=="JA"||euro_dollarnext=="ja"||euro_dollarnext=="Ja")
                        {
                            Console.WriteLine("Ok, I'm sending you to the menu.");
                            continue;

                        }

                        //Euro to dollar continuation input is no
                        else if (euro_dollarnext=="n"||euro_dollarnext=="N"||euro_dollarnext=="NO"||euro_dollarnext=="no"||euro_dollarnext=="No"||euro_dollarnext=="nO"||euro_dollarnext=="NE"||euro_dollarnext=="ne"||euro_dollarnext=="Ne"||euro_dollarnext=="nE")
                        {
                            Console.WriteLine("Ok, I'm shutting down the program.");
                            break;
                        }

                        //Euro to dollar continuation input not understood
                        else
                        {
                            Console.WriteLine("I don't understand the input you just gave me.");
                            Console.WriteLine("I'm sending you to the menu.");
                            continue;
                        }
                    }

                    //Euro to yen
                    else if (euro_currency2=="yen"||euro_currency2=="YEN"||euro_currency2=="Yen"||euro_currency2=="yEn"||euro_currency2=="yEN"||euro_currency2=="YEn"||euro_currency2=="¥")
                    {
                        Console.WriteLine(euro_amount + " Euro/s = " + euro_toyen(euro_amount) + " Yen");
                        Console.WriteLine("Do you want to convert anything else(y/n)?");
                        //Euro to yen continuation input
                        string euro_yennext = Console.ReadLine();

                        //Euro to yen continuation input is yes
                        if (euro_yennext=="y"||euro_yennext=="Y"||euro_yennext=="YES"||euro_yennext=="Yes"||euro_yennext=="yes"||euro_yennext=="yES"||euro_yennext=="JA"||euro_yennext=="ja"||euro_yennext=="Ja"||euro_yennext=="jA")
                        {
                            Console.WriteLine("Ok, I'm sending you to the menu.");
                            continue;
                        }

                        //Euro to yen continuation input is no
                        else if (euro_yennext=="n"||euro_yennext=="N"||euro_yennext=="NO"||euro_yennext=="No"||euro_yennext=="no"||euro_yennext=="nO"||euro_yennext=="Ne"||euro_yennext=="NE"||euro_yennext=="ne"||euro_yennext=="nE")
                        {
                            Console.WriteLine("Ok, I'm shutting down the program.");
                            break;
                        }

                        //Euro to yen continuation input not understood
                        else
                        {
                            Console.WriteLine("I don't understand the input you just gave me.");
                            Console.WriteLine("I'm sending you to the menu.");
                            continue;
                        }
                    
                    }

                    //Euro to Ruble
                    else if (euro_currency2=="Ruble"||euro_currency2=="RUBLE"||euro_currency2=="ruble"||euro_currency2=="rUBLE")
                    {
                        Console.WriteLine(euro_amount + " Euro/s = " + euro_toruble(euro_amount) + " Ruble/s");
                        Console.WriteLine("Do you want to convert anything else(y/n)?");
                        //Euro to ruble continuation input
                        string euro_rublenext = Console.ReadLine();

                        //Euro to ruble continuation input is yes
                        if (euro_rublenext=="y"||euro_rublenext=="Y"||euro_rublenext=="Yes"||euro_rublenext=="YES"||euro_rublenext=="yes"||euro_rublenext=="yES"||euro_rublenext=="JA"||euro_rublenext=="ja"||euro_rublenext=="Ja"||euro_rublenext=="jA")
                        {
                            Console.WriteLine("Ok, I'm sending you to the menu.");
                            continue;
                        }

                        //Euro to ruble continuation input is no 
                        else if (euro_rublenext=="N"||euro_rublenext=="n"||euro_rublenext=="No"||euro_rublenext=="no"||euro_rublenext=="NO"||euro_rublenext=="nO"||euro_rublenext=="Ne"||euro_rublenext=="NE"||euro_rublenext=="ne"||euro_rublenext=="nE")
                        {
                            Console.WriteLine("Ok, I'm shutting down the program.");
                            break;
                        }

                        //Euro to ruble continuation input not understood
                        else
                        {
                            Console.WriteLine("I don't understand the input you just gave me.");
                            Console.WriteLine("I'm sending you to the menu.");
                            continue;
                        }
                   
                    }

                    //Euro to pound
                    else if (euro_currency2=="pound"||euro_currency2=="Pound"||euro_currency2=="POUND"||euro_currency2=="pOUND"||euro_currency2=="GBP"||euro_currency2=="gbp"||euro_currency2=="Gbp"||euro_currency2=="gBP"||euro_currency2=="Funt"||euro_currency2=="funt"||euro_currency2=="FUNT"||euro_currency2=="fUNT")
                    {
                        Console.WriteLine(euro_amount + " Euro/s = " + euro_topound(euro_amount) + " Pound/s(GBP)");
                        Console.WriteLine("Do you want to convert anything else(y/n)?");
                        //Euro to pound continuation input
                        string euro_poundnext = Console.ReadLine();

                        //Euro to pound continuation input is yes
                        if (euro_poundnext=="y"||euro_poundnext=="Y"||euro_poundnext=="Yes"||euro_poundnext=="YES"||euro_poundnext=="yes"||euro_poundnext=="yES"||euro_poundnext=="ja"|euro_poundnext=="Ja"||euro_poundnext=="JA"||euro_poundnext=="jA")
                        {
                            Console.WriteLine("Ok, I'm sending you to the menu.");
                            continue;
                        }

                        //Euro to pound continuation input is no
                        else if (euro_poundnext=="n"||euro_poundnext=="N"||euro_poundnext=="No"||euro_poundnext=="NO"||euro_poundnext=="no"||euro_poundnext=="nO"||euro_poundnext=="NE"||euro_poundnext=="ne"||euro_poundnext=="Ne"||euro_poundnext=="nE")
                        {
                            Console.WriteLine("Ok, I'm shutting down the program.");
                            break;
                        }

                        //Euro to pound continuation input not understood
                        else
                        {
                            Console.WriteLine("I don't understand the input you just gave me.");
                            Console.WriteLine("I'm sending you to the menu.");
                            continue;
                        }
                    }

                    //Euro to currency 2 input is 'exit'                    
                    else if (euro_currency2=="exit"||euro_currency2=="Exit"||euro_currency2=="EXIT"||euro_currency2=="eXIT"||euro_currency2=="Off"||euro_currency2=="off"||euro_currency2=="OFF"||euro_currency2=="oFF")
                    {
                        Console.WriteLine("Ok, I'm shutting down the program.");
                        break;
                    }
                    
                    //Euro to currency 2 input not understood
                    else
                    {
                        Console.WriteLine("I don't understand the input you just gave me.");
                        Console.WriteLine("I'm sending you back to the menu. Make sure you type everything correctly and check for typos.");
                    }
                }

                //Currency 1 input is 'reset'
                else if (currency1=="reset"||currency1=="RESET"||currency1=="Reset"||currency1=="rESET"||currency1=="'reset'"||currency1=="'Reset'"||currency1=="'RESET'"||currency1=="'rESET'")
                {
                    Console.WriteLine("OK, rebooting...");
                    continue;
                }

                //currency 1 input is 'exit'
                else if (currency1=="exit"||currency1=="'exit'"||currency1=="EXIT"||currency1=="eXIT"||currency1=="Exit"||currency1=="Off"||currency1=="off"||currency1=="OFF"||currency1=="oFF")
                {
                    Console.WriteLine("Ok, I'm shutting down the program.");
                    break;
                }

                //currency 1 is Dollar
                else if (currency1=="Dollar"||currency1=="dollar"||currency1=="DOLLAR"||currency1=="dOLLLAR"||currency1=="USD"||currency1=="usd"||currency1=="Usd"||currency1=="uSD"||currency1=="$")
                {
                    Console.WriteLine("You have chosen Dollar(USD).");
                    Console.WriteLine("How many Dollars(USD) do you have?");
                    //Dollar amount input
                    double dollar_amount = double.Parse (Console.ReadLine());

                    Console.WriteLine("Ok, so you have " + dollar_amount + " Dollar/s(USD)");
                    Console.WriteLine("Into which currency do you want to convert these Dollars(USD)(Euro, Yen, Ruble, Pound - GBP)?");
                    //Dollar to currency 2 input
                    string dollar_currency2 = Console.ReadLine();

                    //Dollar to euro
                    if (dollar_currency2=="euro"||dollar_currency2=="EURO"||dollar_currency2=="Euro"||dollar_currency2=="eURO"||dollar_currency2=="EUR"||dollar_currency2=="Eur"||dollar_currency2=="eur"||dollar_currency2=="eUR")
                    {
                        Console.WriteLine(dollar_amount + " Dollar/s(USD) = " + dollar_toeuro(dollar_amount) + " Euro/s");
                        Console.WriteLine("Do you want to convert anything else(y/n)?");
                        //Dollar to euro continuation input
                        string dollar_euronext = Console.ReadLine();

                        //Dollar to euro continuation input is yes
                        if (dollar_euronext=="y"||dollar_euronext=="Y"||dollar_euronext=="YES"||dollar_euronext=="Yes"||dollar_euronext=="yes"||dollar_euronext=="yES"||dollar_euronext=="JA"||dollar_euronext=="ja"||dollar_euronext=="Ja"||dollar_euronext=="jA")
                        {
                            Console.WriteLine("Ok, I'm sending you to the menu.");
                            continue;
                        }

                        //Dollar to euro continuation input is no
                        else if (dollar_euronext=="n"||dollar_euronext=="N"||dollar_euronext=="No"||dollar_euronext=="NO"||dollar_euronext=="no"||dollar_euronext=="nO"||dollar_euronext=="NE"||dollar_euronext=="ne"||dollar_euronext=="Ne"||dollar_euronext=="nE")
                        {
                            Console.WriteLine("Ok, I'm shutting down the program.");
                            break;
                        }

                        //Dollar to euro continuation input not understood
                        else
                        {
                            Console.WriteLine("I don't understand the input you just gave me.");
                            Console.WriteLine("I'm sending you to the menu.");
                            continue;
                        }
                    }

                    //Dollar to yen
                    else if (dollar_currency2=="yen"||dollar_currency2=="YEN"||dollar_currency2=="Yen"||dollar_currency2=="yEN"||dollar_currency2=="¥")
                    {
                        Console.WriteLine(dollar_amount + " Dollar/s(USD) = " + dollar_toyen(dollar_amount) + " Yen(¥)");
                        Console.WriteLine("Do you want to convert anything else(y/n)?");
                        //Dollar to yen continuation input
                        string dollar_yennext = Console.ReadLine();

                        //Dollar to yen continuation input is yes
                        if (dollar_yennext=="y"||dollar_yennext=="Y"||dollar_yennext=="Yes"||dollar_yennext=="YES"||dollar_yennext=="yes"||dollar_yennext=="yES"||dollar_yennext=="JA"||dollar_yennext=="ja"||dollar_yennext=="Ja"||dollar_yennext=="jA")
                        {
                            Console.WriteLine("Ok, I'm sending you to the menu.");
                            continue;
                        }

                        //Dollar to yen continuation input is no
                        else if (dollar_yennext=="n"||dollar_yennext=="N"||dollar_yennext=="No"||dollar_yennext=="NO"||dollar_yennext=="no"||dollar_yennext=="nO"||dollar_yennext=="Ne"||dollar_yennext=="NE"||dollar_yennext=="ne"||dollar_yennext=="nE")
                        {
                            Console.WriteLine("Ok, I'm shutting down the program.");
                            break;
                        }

                        //Dollar to yen continuation input not understood
                        else
                        {
                            Console.WriteLine("I don't understand the input you just gave me.");
                            Console.WriteLine("I'm sending you to the menu");
                            continue;
                        }
                    }

                    //Dollar to currency 2 input is 'exit'
                    else if (dollar_currency2=="exit"||dollar_currency2=="'exit'"||dollar_currency2=="EXIT"||dollar_currency2=="Exit"||dollar_currency2=="eXIT"||dollar_currency2=="off"||dollar_currency2=="Off"||dollar_currency2=="OFF"||dollar_currency2=="oFF")
                    {
                        Console.WriteLine("Ok, I'm shutting down the program");
                        break;
                    }

                    //Dollar to ruble
                    else if (dollar_currency2=="ruble"||dollar_currency2=="RUBLE"||dollar_currency2=="Ruble"||dollar_currency2=="rUBLE")
                    {
                        Console.WriteLine(dollar_amount + " Dollar/s(USD) = " + dollar_toruble(dollar_amount) + " Ruble/s");
                        Console.WriteLine("Do you want to convert anything else(y/n)?");
                        //Dollar to ruble continuation input
                        string dollar_rublenext = Console.ReadLine();

                        //Dollar to ruble continuation input is yes
                        if (dollar_rublenext=="y"||dollar_rublenext=="Y"||dollar_rublenext=="Yes"||dollar_rublenext=="yes"||dollar_rublenext=="YES"||dollar_rublenext=="yES"||dollar_rublenext=="ja"||dollar_rublenext=="Ja"||dollar_rublenext=="JA"||dollar_rublenext=="jA")
                        {
                            Console.WriteLine("Ok, I'm sending you to the menu.");
                            continue;
                        }
                      
                        //Dollar to ruble continuation input is no
                        else if (dollar_rublenext=="n"||dollar_rublenext=="N"||dollar_rublenext=="No"||dollar_rublenext=="NO"||dollar_rublenext=="no"||dollar_rublenext=="nO"||dollar_rublenext=="Ne"||dollar_rublenext=="ne"||dollar_rublenext=="NE"||dollar_rublenext=="nE")
                        {
                            Console.WriteLine("Ok, I'm shutting down the program.");
                            break;
                        }

                        //Dollar to ruble continuation input not understoood
                        else
                        {
                            Console.WriteLine("I don't understand the input you just gave me.");
                            Console.WriteLine("I'm sending you to the menu.");
                            continue;
                        }
                    }

                    //Dollar to pound(GBP)
                    else if (dollar_currency2=="pound"||dollar_currency2=="POUND"||dollar_currency2=="Pound"||dollar_currency2=="pOUND"||dollar_currency2=="pOuNd"||dollar_currency2=="GBP"||dollar_currency2=="gbp"||dollar_currency2=="Gbp"||dollar_currency2=="gBP")
                    {
                        Console.WriteLine(dollar_amount + " Dollar/s(USD) = " + dollar_topound(dollar_amount) + " Pound/s(GBP)");
                        Console.WriteLine("Do you want to convert anything else(y/n)?");
                        //Dollar to pound continuation input
                        string dollar_poundnext = Console.ReadLine();

                        //Dollar to pound continuation input is yes
                        if (dollar_poundnext=="y"||dollar_poundnext=="Y"||dollar_poundnext=="YES"||dollar_poundnext=="Yes"||dollar_poundnext=="yes"||dollar_poundnext=="yES"||dollar_poundnext=="ja"||dollar_poundnext=="Ja"||dollar_poundnext=="JA"||dollar_poundnext=="jA")
                        {
                            Console.WriteLine("Ok, I'm sending you to the menu.");
                            continue;
                        }

                        //Dollar to pound continuation input is no
                        else if (dollar_poundnext=="n"||dollar_poundnext=="N"||dollar_poundnext=="No"||dollar_poundnext=="no"||dollar_poundnext=="NO"||dollar_poundnext=="nO"||dollar_poundnext=="Ne"||dollar_poundnext=="NE"||dollar_poundnext=="nE"||dollar_poundnext=="ne")
                        {
                            Console.WriteLine("Ok, I'm shutting down the program.");
                            break;
                        }

                        //Dollar to pound continuation input not understood
                        else
                        {
                            Console.WriteLine("I don't understand the input you just gave me.");
                            Console.WriteLine("I'm sending you to the menu.");
                            continue;
                        }
                    }

                    //Dollar to currency 2 input is 'reset'
                    else if (dollar_currency2=="reset"||dollar_currency2=="RESET"||dollar_currency2=="Reset"||dollar_currency2=="rESET"||dollar_currency2=="'Reset'"||dollar_currency2=="'RESET'"||dollar_currency2=="'reset'"||dollar_currency2=="'rESET'")
                    {
                        Console.WriteLine("Ok, rebooting...");
                        continue;
                    }

                    //Dollar to currency 2 input not understood
                    else
                    {
                        Console.WriteLine("I don't understand the input you just gave me.");
                        Console.WriteLine("I'm sending you back to the menu. Make sure to type everything correctly and check for typos.");
                        continue;
                    }
                }

                //Currency 1 is Yen(¥)
                else if (currency1=="Yen"||currency1=="YEN"||currency1=="yen"||currency1=="yEN"||currency1== "¥"||currency1=="yEn"||currency1=="YeN")
                {
                    Console.WriteLine("You have chosen Yen.");
                    Console.WriteLine("How many Yen do you have?");
                    //Yen amount input
                    double yen_amount = double.Parse (Console.ReadLine());
                    Console.WriteLine("Ok, so you have " + yen_amount + " Yen");
                    Console.WriteLine("Into which currency do you want to convert these Yen(Euro, Dollar - USD, Ruble, Pound - GBP)?");
                    //Yen to currency 2 input
                    string yen_currency2 = Console.ReadLine();

                    //Yen to euro
                    if (yen_currency2 == "Euro" || yen_currency2 == "EURO" || yen_currency2 == "euro" || yen_currency2 == "eURO" || yen_currency2 == "eUrO" || yen_currency2 == "EuRO" || yen_currency2 == "EuRo" || yen_currency2 == "EUR" || yen_currency2 == "Eur" || yen_currency2 == "eur" || yen_currency2 == "eUR")
                    {
                        Console.WriteLine(yen_amount + " Yen = " + yen_toeuro(yen_amount) + " Euro/s");
                        Console.WriteLine("Do you want to convert anything else(y/n)?");
                        //Yen to euro continuation input
                        string yen_euronext = Console.ReadLine();

                        //Yen to euro continuation input is yes
                        if (yen_euronext == "y" || yen_euronext == "Y" || yen_euronext == "YES" || yen_euronext == "Yes" || yen_euronext == "yes" || yen_euronext == "yES" || yen_euronext == "ja" || yen_euronext == "Ja" || yen_euronext == "JA" || yen_euronext == "jA")
                        {
                            Console.WriteLine("Ok, I'm sending you to the menu.");
                            continue;
                        }

                        //Yen to euro continuation input is no
                        else if (yen_euronext == "n" || yen_euronext == "N" || yen_euronext == "no" || yen_euronext == "No" || yen_euronext == "NO" || yen_euronext == "nO" || yen_euronext == "NE" || yen_euronext == "ne" || yen_euronext == "NE" || yen_euronext == "nE")
                        {
                            Console.WriteLine("Ok, I'm shutting down the program.");
                            break;
                        }

                        //Yen to euro continuation input not understood
                        else
                        {
                            Console.WriteLine("I don't understand the input you just gave me.");
                            Console.WriteLine("I'm sending you to the menu.");
                            continue;
                        }
                    }

                    //Yen to currency 2 input is 'reset'
                    else if (yen_currency2=="reset"||yen_currency2=="Reset"||yen_currency2=="RESET"||yen_currency2=="rESET"||yen_currency2=="rEsEt"||yen_currency2=="'reset'"||yen_currency2=="'Reset'"||yen_currency2=="'RESET'"||yen_currency2=="'rESET'")
                    {
                        Console.WriteLine("Ok, rebooting...");
                        continue;
                    }

                    //Yen to currency 2 input is 'exit'
                    else if (yen_currency2=="exit"||yen_currency2=="Exit"||yen_currency2=="EXIT"||yen_currency2=="eXIT"||yen_currency2=="ExiT"||yen_currency2=="'exit'"||yen_currency2=="'Exit'"||yen_currency2=="'EXIT'"||yen_currency2=="'eXIT'")
                    {
                        Console.WriteLine("Ok, I'm shutting down the program.");
                        break;
                    }

                    //Yen to dollar
                    else if (yen_currency2=="Dollar"||yen_currency2=="DOLLAR"||yen_currency2=="dollar"||yen_currency2=="dOLLAR"||yen_currency2=="DoLlAr"||yen_currency2=="USD"||yen_currency2=="Usd"||yen_currency2=="usd"||yen_currency2=="uSD"||yen_currency2=="uSd")
                    {
                        Console.WriteLine(yen_amount + " Yen = " + yen_todollar(yen_amount) + " Dollar/s (USD)");
                        Console.WriteLine("Do you want to convert anything else(y/n)?");
                        //Yen to dollar continuation input
                        string yen_dollarnext = Console.ReadLine();

                        //Yen to dollar continuation input is yes
                        if (yen_dollarnext=="y"||yen_dollarnext=="Y"||yen_dollarnext=="Yes"||yen_dollarnext=="YES"||yen_dollarnext=="yes"||yen_dollarnext=="yES"||yen_dollarnext=="yEs"||yen_dollarnext=="Ja"||yen_dollarnext=="JA"||yen_dollarnext=="ja"||yen_dollarnext=="jA")
                        {
                            Console.WriteLine("I'm sending you to the menu.");
                            continue;
                        }

                        //Yen to dollar continuation input is no
                        else if (yen_dollarnext=="n"||yen_dollarnext=="N"||yen_dollarnext=="Ne"||yen_dollarnext=="NE"||yen_dollarnext=="ne"||yen_dollarnext=="nE"||yen_dollarnext=="NO"||yen_dollarnext=="No"||yen_dollarnext=="no"||yen_dollarnext=="nO")
                        {
                            Console.WriteLine("Ok, I'm shutting down the program.");
                            break;
                        }

                        //Yen to dollar continuation input not understood
                        else
                        {
                            Console.WriteLine("I don't understand the input you just gave me.");
                            Console.WriteLine("I'm sending you to the menu.");
                            continue;
                        }
                    }

                    //Yen to ruble 
                    else if (yen_currency2=="ruble"||yen_currency2=="Ruble"||yen_currency2=="RUBLE"||yen_currency2=="rUBLE"||yen_currency2=="rUbLe")
                    {
                        Console.WriteLine(yen_amount + " Yen = " + yen_toruble(yen_amount) + " Dollar/s(USD)");
                        Console.WriteLine("Do you want to convert anything else(y/n)?");
                        //Yen to ruble continuation input
                        string yen_rublenext = Console.ReadLine();

                        //Yen to ruble continuation input is yes
                        if (yen_rublenext=="y"||yen_rublenext=="Y"||yen_rublenext=="Yes"||yen_rublenext=="yes"||yen_rublenext=="YES"||yen_rublenext=="yES"||yen_rublenext=="ja"||yen_rublenext=="JA"||yen_rublenext=="Ja"||yen_rublenext=="jA")
                        {
                            Console.WriteLine("Ok, I'm sending you to the menu.");
                            continue;
                        }

                        //Yen to ruble continuation input is no
                        else if (yen_rublenext == "n" || yen_rublenext == "N" || yen_rublenext == "No" || yen_rublenext == "NO" || yen_rublenext == "no" || yen_rublenext == "nO" || yen_rublenext == "ne" || yen_rublenext == "Ne" || yen_rublenext == "NE" || yen_rublenext == "nE")
                        {
                            Console.WriteLine("Ok, I'm shutting down the program.");
                            break;
                        }

                        //Yen to ruble continuation input not understood
                        else
                        {
                            Console.WriteLine("I don't understand the input you just gave me.");
                            Console.WriteLine("I'm sending you to the menu.");
                            continue;
                        }
                    }

                    //Yen to pound
                    else if (yen_currency2=="pound"||yen_currency2=="Pound"||yen_currency2=="POUND"||yen_currency2=="pOUND"||yen_currency2=="pOUnD"||yen_currency2=="GBP"||yen_currency2=="gbp"||yen_currency2=="Gbp"||yen_currency2=="gBP")
                    {
                        Console.WriteLine(yen_amount + " Yen = " + yen_topound(yen_amount) + " Pound/s(GBP)");
                        Console.WriteLine("Do you want to convert anything else(y/n)?");
                        //Yen to pound continuation input
                        string yen_poundnext = Console.ReadLine();
                        
                        //Yen to pound continuation input is yes
                        if (yen_poundnext=="y"||yen_poundnext=="Y"||yen_poundnext=="Yes"||yen_poundnext=="yes"||yen_poundnext=="YES"||yen_poundnext=="yES"||yen_poundnext=="ja"||yen_poundnext=="JA"||yen_poundnext=="Ja"||yen_poundnext=="jA")
                        {
                            Console.WriteLine("Ok, I'm sending you to the menu.");
                            continue;
                        }

                        //Yen to pound continuation input is no
                        else if (yen_poundnext=="n"||yen_poundnext=="N"||yen_poundnext=="No"||yen_poundnext=="NO"||yen_poundnext=="no"||yen_poundnext=="nO"||yen_poundnext=="ne"||yen_poundnext=="NE"||yen_poundnext=="Ne"||yen_poundnext=="nE")
                        {
                            Console.WriteLine("Ok, I'm shutting down the program.");
                            break;
                        }

                        //Yen to pound continuation input not understood
                        else
                        {
                            Console.WriteLine("I don't understand the input you just gave me.");
                            Console.WriteLine("I'm sending you to the menu.");
                            continue;
                        }
                    }

                    //Yen to currency 2 input not understood
                    else
                    {
                        Console.WriteLine("I don't understand the input you just gave me.");
                        Console.WriteLine("I'm sending you back to the menu. Make sure to type everything correctly and check for typos.");
                        continue;
                    }
                }

                //Currency 1 is ruble
                else if (currency1=="Ruble"||currency1=="ruble"||currency1=="RUBLE"||currency1=="rUBLE"||currency1=="rUbLe"||currency1=="RuBlE")
                {
                    Console.WriteLine("You have chosen Ruble.");
                    Console.WriteLine("How many Rubles do you have?");
                    //Ruble amount input
                    double ruble_amount = double.Parse(Console.ReadLine());
                    Console.WriteLine("Ok, so you have " + ruble_amount + " Ruble/s");

                    Console.WriteLine("Into which currency do you want ot convert these Rubles(Euro, Dollar - USD, Yen, Pound - GBP)?");
                    //Ruble to currency 2 input
                    string ruble_currency2 = Console.ReadLine();

                    //Ruble to euro
                    if (ruble_currency2 == "Euro" || ruble_currency2 == "EURO" || ruble_currency2 == "euro" || ruble_currency2 == "eURO" || ruble_currency2 == "eUrO" || ruble_currency2 == "EUR" || ruble_currency2 == "Eur" || ruble_currency2 == "eur" || ruble_currency2 == "eUR")
                    {
                        Console.WriteLine(ruble_amount + " Ruble/s = " + ruble_toeuro(ruble_amount) + " Euro/s");
                        Console.WriteLine("Do you want to convert anything else(y/n)?");
                        //Ruble to euro continuation input
                        string ruble_euronext = Console.ReadLine();

                        //Ruble to euro continuation input is yes
                        if (ruble_euronext == "y" || ruble_euronext == "Y" || ruble_euronext == "YES" || ruble_euronext == "yes" || ruble_euronext == "Yes" || ruble_euronext == "yES" || ruble_euronext == "ja" || ruble_euronext == "JA" || ruble_euronext == "jA" || ruble_euronext == "Ja")
                        {
                            Console.WriteLine("Ok, I'm sending you to the menu.");
                            continue;
                        }

                        //Ruble to euro continuation input is no
                        else if (ruble_euronext == "n" || ruble_euronext == "N" || ruble_euronext == "No" || ruble_euronext == "NO" || ruble_euronext == "no" || ruble_euronext == "nO" || ruble_euronext == "ne" || ruble_euronext == "NE" || ruble_euronext == "Ne" || ruble_euronext == "nE")
                        {
                            Console.WriteLine("Ok, I'm shutting down the program.");
                            break;
                        }

                        //Ruble to euro continuation input not uderstood
                        else
                        {
                            Console.WriteLine("I don't understand the input you just gave me.");
                            Console.WriteLine("I'm sending you to the menu.");
                            continue;
                        }
                    }

                    //Ruble to dollar
                    else if (ruble_currency2 == "dollar" || ruble_currency2 == "DOLLAR" || ruble_currency2 == "Dollar" || ruble_currency2 == "dOLLAR" || ruble_currency2 == "USD" || ruble_currency2 == "Usd" || ruble_currency2 == "usd" || ruble_currency2 == "uSD" || ruble_currency2 == "$")
                    {
                        Console.WriteLine(ruble_amount + " Ruble/s = " + ruble_todollar(ruble_amount) + " Dollar/s(USD)");
                        Console.WriteLine("Do you want to write anything else(y/n)?");
                        //Ruble to dollar continuation input
                        string ruble_dollarnext = Console.ReadLine();

                        //Ruble to dollar continuation input is yes
                        if (ruble_dollarnext == "y" || ruble_dollarnext == "Y" || ruble_dollarnext == "Yes" || ruble_dollarnext == "YES" || ruble_dollarnext == "yes" || ruble_dollarnext == "yES" || ruble_dollarnext == "ja" || ruble_dollarnext == "JA" || ruble_dollarnext == "Ja" || ruble_dollarnext == "jA")
                        {
                            Console.WriteLine("Ok, I'm sending you to the menu.");
                            continue;
                        }

                        //Ruble to dollar continuation input is no
                        else if (ruble_dollarnext == "n" || ruble_dollarnext == "N" || ruble_dollarnext == "No" || ruble_dollarnext == "no" || ruble_dollarnext == "NO" || ruble_dollarnext == "nO" || ruble_dollarnext == "ne" || ruble_dollarnext == "NE" || ruble_dollarnext == "Ne" || ruble_dollarnext == "nE")
                        {
                            Console.WriteLine("Ok, I'm shutting down the program.");
                            break;
                        }

                        //Ruble to dollar continuation input not understood 
                        else
                        {
                            Console.WriteLine("I don't understand the input you just gave me.");
                            Console.WriteLine("I'm sending you to the menu.");
                            continue;
                        }
                    }

                    //Ruble to yen
                    else if (ruble_currency2 == "Yen" || ruble_currency2 == "YEN" || ruble_currency2 == "yen" || ruble_currency2 == "yEN" || ruble_currency2 == "YeN" || ruble_currency2 == "yEn")
                    {
                        Console.WriteLine(ruble_amount + " Ruble/s = " + ruble_toyen(ruble_amount) + " Yen");
                        Console.WriteLine("Do you want to convert anything else(y/n)?");
                        //Ruble to yen continuation input
                        string ruble_yennext = Console.ReadLine();

                        //Ruble to yen continuation input is yes
                        if (ruble_yennext == "Y" || ruble_yennext == "y" || ruble_yennext == "Yes" || ruble_yennext == "yes" || ruble_yennext == "YES" || ruble_yennext == "yES" || ruble_yennext == "yEs" || ruble_yennext == "ja" || ruble_yennext == "JA" || ruble_yennext == "Ja" || ruble_yennext == "jA")
                        {
                            Console.WriteLine("Ok, I'm sending you to the menu.");
                            continue;
                        }

                        //Ruble to yen continuation input is no
                        else if (ruble_yennext == "n" || ruble_yennext == "N" || ruble_yennext == "No" || ruble_yennext == "NO" || ruble_yennext == "no" || ruble_yennext == "nO" || ruble_yennext == "ne" || ruble_yennext == "NE" || ruble_yennext == "Ne" || ruble_yennext == "nE")
                        {
                            Console.WriteLine("Ok, I'm shutting down the program.");
                            break;
                        }

                        //Ruble to yen continuation inout not understood
                        else
                        {
                            Console.WriteLine("I don't understand the input you just gave me");
                            Console.WriteLine("I'm sending you to the menu.");
                            continue;
                        }
                    }

                    //Ruble to pound
                    else if (ruble_currency2 == "Pound" || ruble_currency2 == "POUND" || ruble_currency2 == "pound" || ruble_currency2 == "pOUND" || ruble_currency2 == "POund" || ruble_currency2 == "PoUND" || ruble_currency2 == "GBP" || ruble_currency2 == "gbp" || ruble_currency2 == "Gbp" || ruble_currency2 == "gBP")
                    {
                        Console.WriteLine(ruble_amount + " Ruble/s = " + ruble_topound(ruble_amount) + " Pound/s(GBP)");
                        Console.WriteLine("Do you want to convert anything else(y/n)?");
                        //ruble to pound continuation input
                        string ruble_poundnext = Console.ReadLine();

                        //ruble to pound continuation input is yes
                        if (ruble_poundnext == "y" || ruble_poundnext == "Y" || ruble_poundnext == "Yes" || ruble_poundnext == "YES" || ruble_poundnext == "yes" || ruble_poundnext == "yES" || ruble_poundnext == "ja" || ruble_poundnext == "JA" || ruble_poundnext == "Ja" || ruble_poundnext == "jA")
                        {
                            Console.WriteLine("Ok, I'm sending you to the menu.");
                            continue;
                        }

                        //Ruble to pound continuation input is no
                        else if (ruble_poundnext == "N" || ruble_poundnext == "n" || ruble_poundnext == "No" || ruble_poundnext == "NO" || ruble_poundnext == "no" || ruble_poundnext == "nO" || ruble_poundnext == "ne" || ruble_poundnext == "NE" || ruble_poundnext == "Ne" || ruble_poundnext == "nE")
                        {
                            Console.WriteLine("Ok, I'm shutting down the program.");
                            break;
                        }

                        //Ruble to pound continuation input not understood
                        else
                        {
                            Console.WriteLine("I don't understand the input you just gave me.");
                            Console.WriteLine("I'm sending you to the menu.");
                            continue;
                        }
                    }

                    //Ruble to currency2 input is 'exit'
                    else if (ruble_currency2=="exit"||ruble_currency2=="EXIT"||ruble_currency2=="Exit"||ruble_currency2=="eXIT"||ruble_currency2=="'exit'"||ruble_currency2=="'EXIT'"||ruble_currency2=="'Exit'"||ruble_currency2=="'eXIT'")
                    {
                        Console.WriteLine("Ok, I'm shutting down the program.");
                        break;
                    }

                    //Ruble to currency2 input is 'reset'
                    else if (ruble_currency2=="reset"||ruble_currency2=="RESET"||ruble_currency2=="Reset"||ruble_currency2=="rESET"||ruble_currency2=="'reset'"||ruble_currency2=="'Reset'"||ruble_currency2=="'RESET'"||ruble_currency2=="'rESET'")
                    {
                        Console.WriteLine("Ok, rebooting...");
                        continue;
                    }

                    //Ruble to currency2 input not understood
                    else
                    {
                        Console.WriteLine("I don't understand the input you just gave me.");
                        Console.WriteLine("I'm sending you back to the menu. Make sure to type everything correctly and check for typos.");
                        continue;
                    }
                }

                //Currency 1 is Pound-GBP
                else if (currency1=="Pound"||currency1=="POUND"||currency1=="pound"||currency1=="pOUND"||currency1=="PoUnD"||currency1=="GBP"||currency1=="gbp"||currency1=="gBP"||currency1=="Gbp")
                {
                    Console.WriteLine("You have chosen Pound(GBP).");
                    Console.WriteLine("How many Pounds(GBP) do you have?");
                    //Pound amount input
                    double pound_amount = double.Parse (Console.ReadLine());

                    Console.WriteLine("Ok, so you have " + pound_amount + " Pound/s(GBP).");
                    Console.WriteLine("Into which currency do you want to convert these Pounds(GBP) (Euro, Dolllar - USD, Yen, Ruble)?");
                    //Pound to currency2 input
                    string pound_currency2 = Console.ReadLine();

                    //Pound to euro
                    if (pound_currency2=="Euro"||pound_currency2=="EURO"||pound_currency2=="euro"||pound_currency2=="eURO"||pound_currency2=="EuRO"||pound_currency2=="eUro"||pound_currency2=="EUR"||pound_currency2=="Eur"||pound_currency2=="eur"||pound_currency2=="eUR")
                    {
                        Console.WriteLine(pound_amount + " Pound/s(GBP) = " + pound_toeuro(pound_amount) + " Euro/s");
                        Console.WriteLine("Do you want to convert anything else(y/n)?");
                        //Pound to euro continuation input 
                        string pound_euronext = Console.ReadLine();

                        //Pound to euro continuation input is yes
                        if (pound_euronext=="y"||pound_euronext=="Y"||pound_euronext=="Yes"||pound_euronext=="YES"||pound_euronext=="yes"||pound_euronext=="yES"||pound_euronext=="ja"||pound_euronext=="JA"||pound_euronext=="Ja"||pound_euronext=="jA")
                        {
                            Console.WriteLine("Ok, I'm sending you to the menu.");
                            continue;
                        }

                        //Pound to euro continuation input is no
                        else if (pound_euronext=="n"||pound_euronext=="N"||pound_euronext=="No"||pound_euronext=="NO"||pound_euronext=="no"||pound_euronext=="nO"||pound_euronext=="ne"||pound_euronext=="NE"||pound_euronext=="Ne"||pound_euronext=="nE")
                        {
                            Console.WriteLine("Ok, I'm shutting down the program.");
                            break;
                        }

                        //Pound to euro continuation input not understood
                        else
                        {
                            Console.WriteLine("I don't understand the input you just gave me.");
                            Console.WriteLine("I'm sending you to the menu.");
                            continue;
                        }
                    }

                    //Pound to dollar
                    else if (pound_currency2=="dollar"||pound_currency2=="DOLLAR"||pound_currency2=="Dollar"||pound_currency2=="dOLLAR"||pound_currency2=="DOllar"||pound_currency2=="doLLAR"||pound_currency2=="USD"||pound_currency2=="usd"||pound_currency2=="Usd"||pound_currency2=="uSD"||pound_currency2=="USd"||pound_currency2=="usD")
                    {
                        Console.WriteLine(pound_amount + " Pound/s(GBP) = " + pound_todollar(pound_amount) + " Dollar/s(USD)");
                        Console.WriteLine("Do you want to convert anything else(y/n)?");
                        //Pound to dollar continuation input
                        string pound_dollarnext = Console.ReadLine();

                        //Pound to dollar continuation input is yes
                        if (pound_dollarnext=="y"||pound_dollarnext=="Y"||pound_dollarnext=="Yes"||pound_dollarnext=="YES"||pound_dollarnext=="yes"||pound_dollarnext=="yES"||pound_dollarnext=="JA"||pound_dollarnext=="ja"||pound_dollarnext=="Ja"||pound_dollarnext=="jA")
                        {
                            Console.WriteLine("Ok, I'm sending you to the menu.");
                            continue;
                        }

                        //Pound to dollar continuation input is no
                        else if (pound_dollarnext=="n"||pound_dollarnext=="N"||pound_dollarnext=="No"||pound_dollarnext=="no"||pound_dollarnext=="NO"||pound_dollarnext=="nO"||pound_dollarnext=="ne"||pound_dollarnext=="NE"||pound_dollarnext=="Ne"||pound_dollarnext=="nE")
                        {
                            Console.WriteLine("Ok, i'm shutting down the program.");
                            break;
                        }

                        //Pound to dollar continuation input not understood
                        else
                        {
                            Console.WriteLine("I don't understand the input you just gave me.");
                            Console.WriteLine("I'm sending you to the menu.");
                        }
                    }

                    //Pound to yen
                    else if (pound_currency2=="yen"||pound_currency2=="YEN"||pound_currency2=="Yen"||pound_currency2=="yEN"||pound_currency2=="YEn")
                    {
                        Console.WriteLine(pound_amount + " Pound/s(GBP) = " + pound_toyen(pound_amount) + " Yen");
                        Console.WriteLine("Do you want to convert anything else(y/n)?");
                        //Pound to yen continuation input
                        string pound_yennext = Console.ReadLine();

                        //Pound to yen continuation input is yes
                        if (pound_yennext=="y"||pound_yennext=="Y"||pound_yennext=="Yes"||pound_yennext=="yes"||pound_yennext=="YES"||pound_yennext=="yES"||pound_yennext=="ja"||pound_yennext=="JA"||pound_yennext=="Ja"||pound_yennext=="jA")
                        {
                            Console.WriteLine("Ok, I'm sending you to the menu.");
                            continue;
                        }

                        //Pound to yen continuation input is no
                        else if(pound_yennext=="n"||pound_yennext=="N"||pound_yennext=="No"||pound_yennext=="no"||pound_yennext=="NO"||pound_yennext=="nO"||pound_yennext=="ne"||pound_yennext=="NE"||pound_yennext=="Ne"||pound_yennext=="nE")
                        {
                            Console.WriteLine("Ok, I'm shutting down the program.");
                            break;
                        }

                        //Pound to yen continuation input not understood
                        else
                        {
                            Console.WriteLine("I don't understand the input you just gave me.");
                            Console.WriteLine("I'm sending you to the menu.");
                            continue;
                        }
                    }

                    //Pound to ruble
                    else if (pound_currency2=="ruble"||pound_currency2=="Ruble"||pound_currency2=="RUBLE"||pound_currency2=="rUBLE"||pound_currency2=="RUble"||pound_currency2=="ruBLE")
                    {
                        Console.WriteLine(pound_amount + " Pound/s(GBP) = " + pound_toruble(pound_amount) + " Ruble/s");
                        Console.WriteLine("Do you want to convert anything else(y/n)?");
                        //Pound to ruble continuation input
                        string pound_rublenext = Console.ReadLine();

                        //Pound to ruble continuation input is yes
                        if (pound_rublenext=="Y"||pound_rublenext=="y"||pound_rublenext=="Yes"||pound_rublenext=="yes"||pound_rublenext=="YES"||pound_rublenext=="yES"||pound_rublenext=="JA"||pound_rublenext=="Ja"||pound_rublenext=="ja"||pound_rublenext=="jA")
                        {
                            Console.WriteLine("Ok, I'm sending you to the menu");
                            continue;
                        }                   

                        //Pound to ruble continuation input is no
                        else if (pound_rublenext=="n"||pound_rublenext=="N"||pound_rublenext=="No"||pound_rublenext=="NO"||pound_rublenext=="no"||pound_rublenext=="nO"||pound_rublenext=="ne"||pound_rublenext=="NE"||pound_rublenext=="Ne"||pound_rublenext=="nE")
                        {
                            Console.WriteLine("Ok, I'm shutting down the program.");
                            break;
                        }

                        //Pound to ruble continuation input not understood
                        else
                        {
                            Console.WriteLine("I don't understand the input you just gave me.");
                            Console.WriteLine("I'm sending you to the menu.");
                            continue;
                        }
                    }

                    //Pound to currency 2 input is 'exit'
                    else if (pound_currency2=="exit"||pound_currency2=="EXIT"||pound_currency2=="Exit"||pound_currency2=="'exit'"||pound_currency2=="'EXIT'"||pound_currency2=="'Exit'"||pound_currency2=="'eXIT'")
                    {
                        Console.WriteLine("Ok, I'm shutting down the program.");
                        break;
                    }

                    //Pound to currency 2 input is 'reset'
                    else if (pound_currency2=="reset"||pound_currency2=="RESET"||pound_currency2=="Reset"||pound_currency2=="rESET"||pound_currency2=="'reset'"||pound_currency2=="'RESET'"||pound_currency2=="'Reset'"||pound_currency2=="'rESET'")
                    {
                        Console.WriteLine("Ok, rebooting...");
                        continue;
                    }

                    //Pound to currency 2 input not understood
                    else
                    {
                        Console.WriteLine("I don't understand the input you just gave me.");
                        Console.WriteLine("I'm sending you back to the menu. Make sure to type everything correctly and check for typos.");
                        continue;
                    }

                }
                
                //Currency 1 input not understood
                else
                {
                    Console.WriteLine("I don't understand the input you just gave me.");
                    Console.WriteLine("I'm sending you back to the menu. Make sure to type everything correctly and check for typos.");
                    continue;
                }
            }
        }
    }
}
