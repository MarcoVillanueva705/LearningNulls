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

            Console.Write(s2);

            //null coalescing does not work with value types
            //because value types cannot be Null unless specified
            //explicitly i.e. 'int' etc.
            //use the '?'  in order for it work
            //great way to deal with Null when a default value is required

            //int? s = null;
            //int s2 = s ?? 2;
            //Console.WriteLine(s2);

        }
    }
}
