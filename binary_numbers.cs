using System.CodeDom.Compiler;
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



    static void Main(string[] args) {
        int n = Convert.ToInt32(Console.ReadLine());
        string binary = Convert.ToString(n, 2);

        //Console.WriteLine(binary);

        int count = 0;
        int max = 0;

        for(int i = 0; i < binary.Length; i++)
        {
            if(binary[i]=='1'){
                count++;
                if(count>max)
                    max = count;
                //Console.WriteLine(count);
            }
            else
            {
                if(count>max)
                    max = count;
                count = 0;
                //Console.WriteLine(count);
            }
            
        }
        Console.WriteLine(max);
    }
}
