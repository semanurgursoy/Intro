﻿using System;
using System.Collections.Generic;

namespace GenericsIntro
{
    class Program
    {
        static void Main(string[] args)
        {
            MyList<string> names = new MyList<string>();
            names.Add("Engin");

            List<string> list = new List<string>();
            Console.WriteLine(list.Count);
        }
    }
}
