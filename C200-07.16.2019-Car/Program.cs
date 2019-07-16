using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C200_07._16._2019_Car
{
    class Program
    {
        static void Main(string[] args)
        {
            Car bmw = new Car("Bmw","M5");



            string userInput;
            do
            {
                Console.WriteLine("1.Go");
                Console.WriteLine("2.Top Up");
                Console.WriteLine("3.Local km");
                Console.WriteLine("4.Global km");
                Console.WriteLine("5.Exit");
                Console.Write(">>>>>>");
                userInput = Console.ReadLine();
                if (CheckInput(userInput))
                {
                   switch (userInput)
                    {
                        case "1":
                            bmw.Go();
                            break;
                        case "2":
                            bmw.TopUP();
                            break;
                        case "3":
                            Console.WriteLine("Local Km");
                            break;
                        case "4":
                            Console.WriteLine("Global Km");
                            break;
                        default:
                            Console.WriteLine("Xahis edirik yuxaridaki reqemlerden birini daxil edin!");
                            break;
                    }

                }
                else
                {
                    Console.WriteLine("Zehmet olmasa reqem daxil edin");
                }
            } while (userInput != "5");
          
        }
        public static bool CheckInput(string inp)
        {
            try
            {
                Convert.ToInt32(inp);
                return true;
            }
            catch (Exception)
            {

                return false;
            }
        }
    }
    
    class Car
    {
        public string Marka;
        public string Model;
        private double CurrentFuel;
        private int MaxFuel;
        private int ConsumeFuel;
        public Car(string Marka, string model, int currentfuell = 60, int maxfuell = 80, int consumeFuel = 14)
        {
            this.Marka = Marka;
            Model = model;
            CurrentFuel = currentfuell;
            MaxFuel = maxfuell;
            ConsumeFuel = consumeFuel;
    }
      
        public void Go()
        {
            Console.WriteLine("Nece km Getmek isteyirsiz?");
           string input= Console.ReadLine();
            if (CheckInput(input))
            {
                double neededKm = 0;
                while (neededKm == 0)
                {
                    neededKm = Convert.ToDouble(input);

                    if (CurrentFuel<= neededKm/100*ConsumeFuel)
                    {
                        Console.WriteLine("Sizin kifayet qeder benziniz yoxdur.Zehmet olmasa benzin doldurun");
                    }
                    else
                    {
                        CurrentFuel -=  neededKm / 100 * ConsumeFuel;
                        Console.WriteLine("Sizin {0} km yol getdiniz.Hal-hazirda {1}lt benzininiz qaldi",neededKm,CurrentFuel);
                    }
                }
            }
            else
            {
                Console.WriteLine("Xahis edirik km-i musbet reqem daxil edin");
            }

        }
        public void TopUp()
        {
            Console.WriteLine("Ne qeder benzin yuklemek isteyirsiz?");
           string need= Console.ReadLine();
            if (CheckInput(need))
            {

            }
            else
            {
                Console.WriteLine("Xahis edirik km-i musbet reqem daxil edin");
            }
        }
        public  bool CheckInput(string inp)
        {
            try
            {
                Convert.ToUInt32(inp);
                return true;
            }
            catch (Exception)
            {

                return false;
            }
        }
    }
}
