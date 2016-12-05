﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SourceCodePrettyHair;

namespace PrettyHairUI
{
    class Program
    {

        static void Main(string[] args)
        {
            Program program = new Program();
            program.Run();

        }


        public void Run()
        {
            ConsoleFunctions konsolfunktioner = new ConsoleFunctions();
            konsolfunktioner.ShowProductList();
            konsolfunktioner.CreateOrderByConsole();
            konsolfunktioner.ProcessOrder();
            konsolfunktioner.ShowProductList();
            Console.ReadKey();
                         
        }

    }
}
