﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace console_app
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("what's your name?");
            var name = Console.ReadLine();
            Console.WriteLine("Fuck you, " + name);
            Console.ReadLine();
        }
    }
}