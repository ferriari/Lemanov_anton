﻿using System;

namespace ConsoleApp2 { }
class if_Program
{
    static void Stepen (string[] args)
    {
        int a = int.Parse(Console.ReadLine());
        int b = int.Parse(Console.ReadLine());
        int d = a;
        if (b > 0)
        {
            d = d * a;
            b--;
        }
        Console.WriteLine(d);



    }
    static void Obratnoechislo (string[] args)
    {
        long a = int.Parse(Console.ReadLine());
        long b = 0;
        while (a > 0)
        {
            b = b * 10 + a % 10;
            a = a / 10;
        }


        Console.WriteLine(b);



    }
    static void YdalenieChisla (string[] args)
    {
        int a = int.Parse(Console.ReadLine());
        int b = int.Parse(Console.ReadLine());
        int d = 0;
        int c = 0;
        int h = 0;
        while (a > 0)
        {
            c = a % 10;
            if (c != b)
            {
                d = d * 10 + a % 10;
            }
            a = a / 10;
        }
        while (d > 0)
        {
            h = h * 10 + d % 10;
            d = d / 10;
        }
        Console.WriteLine(c);
    }
    static void YdalenieOdenakovogochisla(string[] args)
    {
        long a = int.Parse(Console.ReadLine());
        long b = int.Parse(Console.ReadLine());
        long bas = 0;
        long bes = 0;
        long h = 0;
        long hh = 0;
        long rr = 0;
        long gg = 0;

        while (a > 0 | b > 0)
        {
            bas = a % 10;
            bes = b % 10;
            a = a / 10;
            b = b / 10;
            if (bas != bes)
            {
                h = bas + h * 10;
                hh = bes + hh * 10;

            }
        }
        while (h > 0 | hh > 0)
        {
            bas = h % 10;
            bes = hh % 10;
            h = h / 10;
            hh = hh / 10;
            rr = bas + rr * 10;
            gg = bes + gg * 10;
        }
        Console.WriteLine(rr);
        Console.WriteLine(gg);

    }
}
