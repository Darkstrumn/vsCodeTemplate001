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

   static long Challenge(int n, int[] arr) {
        var ret = 0;

        System.Diagnostics.Debug.Print($"Challenge||BPx: {ret}\n");

        return ret;
    }

    static void Main(string[] args) {
        var input = new int[]{2,4,2,6,1,7,8,9,2,1};
        long result = Challenge(rankings.Length, rankings);
        Console.WriteLine(result.ToString());
    }
    
    /*
    Supports second argument to specify if logging is to console or debug only
    */
    static void Logger(string[] args) {
        if(args.Length == 1 || (args.Length > 1 && args[1]="degugOnly")){System.Diagnostics.Debug.Print($"Challenge||BPx: {ret}\n");}
        if(args.Length == 1 || (args.Length > 1 && args[1]="consoleOnly")){Console.WriteLine(result.ToString());}
    	}
}