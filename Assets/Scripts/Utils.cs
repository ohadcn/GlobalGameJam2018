using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

class Utils
{
    static System.Random rand = new System.Random();

    public static float Rangify(double x)
    {
        return (float)(x * rand.NextDouble() * 2 - x);
    }

}
