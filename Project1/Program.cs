using System.Collections.Generic;
using System.Runtime;
using System.Diagnostics;
using System;
using System.IO;
class Program
{
    static void Main()
    {
        List<List<string>> abc = new List<List<string>>();
        abc.Add("123");
        Console.Write(abc[0][0]);
    }
}
