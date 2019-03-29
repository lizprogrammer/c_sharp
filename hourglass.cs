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
        double[][] arr = new double[6][];
        double bigNumber = -1;
        double counter = -1;
        double [] sum = new double[16];

        for (int i = 0; i < 6; i++) {
            arr[i] = Array.ConvertAll(Console.ReadLine().Split(' '), arrTemp => Convert.ToDouble(arrTemp));
        }
        for(int i = 0; i < 4; i+=1){
            for(int j = 0; j < 4; j+=1){

                // Console.Write(arr[i][j]);
                // Console.Write(arr[i][j+1]);
                // Console.Write(arr[i][j+2]);
                // Console.WriteLine();
                // Console.Write(" ");
                // Console.Write(arr[i+1][j+1]);
                // Console.Write(" ");
                // Console.WriteLine();
                // Console.Write(arr[i+2][j]);
                // Console.Write(arr[i+2][j+1]);
                // Console.Write(arr[i+2][j+2]);
                // Console.WriteLine();
                // Console.WriteLine();
                counter = arr[i][j] +arr[i][j+1]+arr[i][j+2]+arr[i+1][j+1]+arr[i+2][j]+arr[i+2][j+1]+arr[i+2][j+2];
                if(counter > bigNumber){
                    bigNumber = counter;
                }
                else{
                    //bigNumber = bigNumber;
                }
                sum[i+j] = counter;
            }
            // Console.WriteLine();
        }
        // Console.WriteLine();
        Console.WriteLine(sum.Max());
    }
   
}
