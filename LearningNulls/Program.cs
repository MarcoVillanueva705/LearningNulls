using System;

namespace LearningNulls
{
    class Program
    {
        static void Main(string[] args)
        {
            //Null coalescing allows to deal with possibly
            //having Nulls
            String s = null; //"hello";
            //you get the default string since first string is Null
            var s2 = s ?? "default";

            Console.Write(s2)
        }
    }
}
