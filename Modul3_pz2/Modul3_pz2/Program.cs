﻿namespace Modul3_pz2
{
    using System;
    using System.Linq;

    public class Program
    {
        public static void Main(string[] args)
        {
            string[] names = { "Denis", "Mark", "Sasha", "Dasha", "Misha" };

            var selectNames = names.Where(w => w.FirstOrDefault().Skip("D"));
        }
    }
}
