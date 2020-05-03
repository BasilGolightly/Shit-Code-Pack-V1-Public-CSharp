using System;

namespace Dumbass1
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("Hello!!");
            Console.WriteLine("Gun maker is starting up...");
            Console.WriteLine("Which gun are you trying to make?(Choose one of these: AK-47/Avtomat Kalashnikova/AK;M4;Sniper;");
            string gun = Console.ReadLine();

            //gun choice


            //AK47 here.
            while (gun == "ak" || gun == "AK" || gun == "Avtomat Kalashnikova" || gun == "AK-47" || gun == "AK47" || gun == "ak47")
            {

                Console.WriteLine("How much sheet metal do you have (500 is enough)");
                int sheet_ak = Convert.ToInt32(Console.ReadLine());
                //sheet metal input  

                if (sheet_ak >= 500)
                {

                    //wood amount input
                    Console.WriteLine("Ok, how much wood do you have?(100 is enough)");
                    int wood_ak = Convert.ToInt32(Console.ReadLine());


                    //enough wood 
                    if (wood_ak >= 100)
                    {
                        Console.WriteLine("You have enough sheet metal for " + Convert.ToDouble(sheet_ak) / 500 + " AK-47 body/ies. And enough wood for " + Convert.ToDouble(wood_ak) / 100 + " stock/s and grip/s");
                        Console.WriteLine("Here you go ︻╦╤─. You have succesfully made your first ak");
                        Console.WriteLine("Have a good day!");
                        break;
                        //gun is made
                    }

                    else
                    {
                        Console.WriteLine("No AK-47 for you today. )=");
                        //not enough wood
                    }

                }

                else
                {
                    Console.WriteLine("No AK for you today. )=");
                    break;
                    //not enough sheet metal/no ak47
                }


                
            }    

                while (gun=="M4" || gun == "m4")
                {
                    Console.WriteLine("How much plastic do you have?(300 is enough)");
                    int plastic_m4 = Convert.ToInt32(Console.ReadLine());
                    //plastic m4 input

                      if (plastic_m4 >= 300)
                      {
                        Console.WriteLine("How much metal do you have?(700 is enough)");
                        int metal_m4 = Convert.ToInt32(Console.ReadLine());
                        //METAL INPUT M4
                          if (metal_m4 >= 700)
                          {
                            Console.WriteLine("So, you have enough plastic for " + Convert.ToDouble(plastic_m4) / 300 + " stock/s and grip/s and enough metal for " + Convert.ToDouble(metal_m4) / 700 + " M4 body/ies");
                            Console.WriteLine("Congratulations, you have made your first M4. Unfourtunately, Trump has taken away your M4 for 'the greater good'.");
                            break;
                           // m4 is made, trump takes it
                          
                          }

                        else
                        {
                            Console.WriteLine("No M4 for you today. )=");
                            break;
                            //not enough metal.
                        }
                      }

                      else
                      {
                        Console.WriteLine("No M4 for you today. )=");
                        break;
                      }
                         //not enough plastic               
                
                }

            while (gun == "sniper" || gun == "Sniper" || gun == "SNIPER" || gun == "SnIpeR")//sniper being made
            {
                Console.WriteLine("How much metal do you have (1000 is enough)");
                int metal_sniper = Convert.ToInt32(Console.ReadLine());
                //sniper metal input

                if (metal_sniper >= 1000)
                {
                    Console.WriteLine("How much plastic/wood do you have(200 is enough)");
                    int body_stockgrip = Convert.ToInt32(Console.ReadLine());
                    //sniper stock(plastic/wood)input

                    if (body_stockgrip >= 200)
                    {
                        Console.WriteLine("How much 3x lenses do you have?(5 are enough)");
                        int lenses = Convert.ToInt32(Console.ReadLine());
                        //lens input

                        if (lenses >= 5)
                        {
                            Console.WriteLine("So you have enough metal for " + Convert.ToDouble(metal_sniper) / 1000 + " body/ies, enough plastic/wood for " + Convert.ToDouble(body_stockgrip) / 200 + " stock/s and enough 3x lenses for " + Convert.ToDouble(lenses) / 5 + " scopes/s.");
                            Console.WriteLine("Congratulations, you have succesfully made your first sniper!");
                            Console.WriteLine("Here you go ︻デ═一");
                            Console.WriteLine("Have a nice day!");
                            //sniper is made
                            break;

                        }


                        else
                        {
                            Console.WriteLine("No scope today. But you did make a sniper anyway. Here you go ︻П═一 ");
                            Console.WriteLine("So congratulations!");
                            Console.WriteLine("Have a nice day!");
                            break;
                        
                        }//sniper is made but no scope involved
                    
                    }

                    else
                    {
                        Console.WriteLine("No sniper today: )=");
                        break;
                        //not enough wood/plastic
                    }

                }

                else
                {
                    Console.WriteLine("No sniper today. )=");
                    break;
                    //not enough metal
                }


            }
        }
    }
}
