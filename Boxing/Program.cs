﻿using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Boxing
{
    class Program
    {
        static void Main(string[] args)
        {

            var list = new ArrayList();
            list.Add(1);
            list.Add("Chris");
            list.Add(DateTime.Today);

            var number = (int)list[1];


            var anotherList = new List<int>();
            anotherList.Add(2);

            var names = new List<string>();
            names.Add("Chris");



        }
    }
}
