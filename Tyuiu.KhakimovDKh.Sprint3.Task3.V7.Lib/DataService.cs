﻿
using tyuiu.cources.programming.interfaces.Sprint3;
namespace Tyuiu.KhakimovDKh.Sprint3.Task3.V7.Lib
{
    public class DataService : ISprint3Task3V7
    {
        public string ReplaceCharOnNum(string value, char replaceable, char replacement)
        {
            string str = "gft hggt ntg";
            foreach (char rpb in str)
            {
                if (rpb == 'g')
                {
                    str = str.Replace(rpb, '4');
                }

            }
            return str;
        }
    }
}
