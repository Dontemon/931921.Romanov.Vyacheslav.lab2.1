using System;
namespace lab2._1.Models
{
    public class CalcModel
    {
        public Random random = new Random();
        public int first;
        public int second;
        public int sumResult;
        public int minesResult;
        public int multResult;
        public int divResult;
        public bool divNull = false;
        public void Calculator()
        {
            first = random.Next(0, 100);
            second = random.Next(0, 100);
            sumResult = first + second;
            minesResult = first - second;
            multResult = first * second;
            if(second != 0)
                divResult = first / second;
            else
                divNull= true;
        }
    }
}