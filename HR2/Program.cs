﻿using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Collections;
using System.ComponentModel;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.Serialization;
using System.Text.RegularExpressions;
using System.Text;
using System;

class Solution {
    // Complete the staircase function below.
    static void staircase(int n) {
        int steps = 1;

        while (steps <= n) {
            string spc = new string(' ', n - steps);
            string str = new string('#', steps);
            if (steps == n) {
                Console.Write($"{spc}{str}");
            }
            else {
                Console.WriteLine($"{spc}{str}");
            }
            steps++;
        }
    }

    static void Main(string[] args) {
        int n = Convert.ToInt32(Console.ReadLine());

        staircase(n);
    }
}
