﻿using System;
using System.Linq;

namespace ABC265
{
    class B
    {
        static void Main(string[] args)
        {
            var B = new B();
            var input= B.Read_int();
            var n = input[0];
            var m = input[1];
            var t = input[2];
            var a= B.Read_int();

            Enumerable.Range(0,m).ToList().ForEach( i=> {
                string[] xy = Console.ReadLine().Trim().Split(' ');
                var x = int.Parse(xy[0])-1;
                var y = int.Parse(xy[1]);
                a[x] -=y;
            });

            Console.WriteLine(a.Select(x => t-=x).Count(x => x <= 0) == 0? "Yes": "No");
        }
        List<int> Read_int()
        {
            var check = new List<bool>();
            var input = Console.ReadLine().Split(' ').Select(x => {
                var temp = 0;
                check.Add(int.TryParse(x, out temp));
                return temp;
            }).ToList();
            if (check.Any(x => x == false)) return null;
            return input;
        }
    }
}
