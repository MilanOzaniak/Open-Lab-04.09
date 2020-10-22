using System;
using System.Collections.Generic;
using System.Linq;

namespace Open_Lab_04._09
{
    public class ArrayTools
    {
        public string[] RemoveDups(string[] strings)
        {
            var list = new List<string>(strings);
            return list.Distinct().ToArray();

        }
    }
}
