using System;
using tyuiu.cources.programming.interfaces.Sprint3;

namespace Tyuiu.TinkovSS.Sprint3.Task3.V21.Lib
{
    public class DataService : ISprint3Task3V21
    {
        public string ReplaceNumOnChar(string value, char item)
        {
            foreach (char chr in value)
            {
                if (char.IsDigit(chr))
                {
                    value = value.Replace(chr, item);
                }
            }
            return value;
        }
    }
}