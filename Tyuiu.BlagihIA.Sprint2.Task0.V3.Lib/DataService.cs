﻿using tyuiu.cources.programming.interfaces.Sprint2;
namespace Tyuiu.BlagihIA.Sprint2.Task0.V3.Lib
{
    public class DataService : ISprint2Task0V0
    {
        public bool[] GetCompareOperations(int x, int y)
        {
            bool[] res = new bool[6];

            res[0] = x * 2 == y;
            res[1] = x != y;
            res[2] = x + 99 < y;
            res[3] = 10 * x > y;
            res[4] = x + 83 <= y;
            res[5] = x >= y - 100;

            return res;
        }
    
    }
}