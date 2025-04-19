using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Non_GenericCollections
{
    internal class StringsDisplay
    {
        public static void DisplayStrings()
        {
            ArrayList al = new ArrayList();
            al.Add(10);
            al.Add("Aditya");
            al.Add(true);
            al.Add(20);
            al.Add("Sohel");
            al.Add(false);
            for(int i = 0; i < al.Count; i++)
            {
                string str = al[i] as string;
                if (str != null)
                {
                    Console.WriteLine(str);
                }
            }
        }
    }
}