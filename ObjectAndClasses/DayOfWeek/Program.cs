﻿using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DayOfWeek
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = DateTime
                .ParseExact(Console.ReadLine(), "d-M-yyyy", CultureInfo.InvariantCulture);

            Console.WriteLine(input.DayOfWeek);
        }
    }
}
