﻿using System.Runtime.InteropServices;

namespace _7._Vending_Machine
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // valid coins: •	0.1, 0.2, 0.5, 1 and 2
            string inputCoins=Console.ReadLine();
            double money = 0;
            while (inputCoins!="Start")
            {
                double amountOfCoins=double.Parse(inputCoins);

                if (amountOfCoins == 0.1)
                {
                    money += amountOfCoins;
                }
                else if (amountOfCoins == 0.2)
                {
                    money += amountOfCoins;
                }
                else if (amountOfCoins == 0.5)
                {
                    money += amountOfCoins;
                }
                else if (amountOfCoins == 1)
                {
                    money += amountOfCoins;
                }
                else if (amountOfCoins == 2)
                {
                    money += amountOfCoins;
                }
                else
                {
                    Console.WriteLine($"Cannot accept {amountOfCoins}");
                }
                inputCoins = Console.ReadLine();
            }
            string product = Console.ReadLine();
            while (product!="End")
            {
                if (product=="Nuts")
                {
                    if (money>=2)
                    {
                        money -= 2;
                        Console.WriteLine($"Purchased {product.ToLower()}");
                    }
                    else
                    {
                        Console.WriteLine("Sorry, not enough money");
                    }
                }
                else if (product=="Water")
                {
                    if (money >= 0.7)
                    {
                        money -= 0.7;
                        Console.WriteLine($"Purchased {product.ToLower()}");
                    }
                    else
                    {
                        Console.WriteLine("Sorry, not enough money");
                    }
                }
                else if (product=="Crisps")
                {
                    if (money >= 1.5)
                    {
                        money -= 1.5;
                        Console.WriteLine($"Purchased {product.ToLower()}");
                    }
                    else
                    {
                        Console.WriteLine("Sorry, not enough money");
                    }
                }
                else if (product=="Soda")
                {
                    if (money >= 0.8)
                    {
                        money -= 0.8;
                        Console.WriteLine($"Purchased {product.ToLower()}");
                    }
                    else
                    {
                        Console.WriteLine("Sorry, not enough money");
                    }
                }
                else if (product=="Coke")
                {
                    if (money >= 1)
                    {
                        money -= 1;
                        Console.WriteLine($"Purchased {product.ToLower()}");
                    }
                    else
                    {
                        Console.WriteLine("Sorry, not enough money");
                    }
                }
                else
                {
                    Console.WriteLine("Invalid product");
                }
                product = Console.ReadLine();
            }

            Console.WriteLine($"Change: {money:F2}");
            
        }
    }
}