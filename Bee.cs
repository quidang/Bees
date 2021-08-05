using System.Diagnostics;
using System.Threading;
using System.Runtime.CompilerServices;
using System;
using System.Globalization;

public class Bee
{
    public string name {get; set;}
    public float size {get; set;}

    public Bee(string name, float size)
    {
         this.name = name;
         this.size = size;
    }
}