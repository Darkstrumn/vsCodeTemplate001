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
using com.darktechsystems;

class Solution {

   static string Challenge() {
        var logger = new Logger();
        var ret = "Hello World!";
        return ret;
    }

    static void Main(string[] args) {
        var logger = new Logger();
        var result = Challenge();
        logger.Log(result.ToString());
    }
}