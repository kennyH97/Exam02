using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam02
{
    public class Student : IStudent
    {
        public int StudID { get; set; }
        public string StudName { get; set; }
        public string StudGender { get; set; }
        public int StudAge { get; set; }
        public string StudClass { get; set; }
        public float StudAvgMark { get; private set; }

        public void Print()
        {
            Console.WriteLine("Student Info: ");
            Console.WriteLine("ID: " + StudID);
            Console.WriteLine("Name: " + StudName);
            Console.WriteLine("Gender: " + StudGender);
            Console.WriteLine("Age: " + StudAge);
            Console.WriteLine("Class: " + StudClass);
            Console.WriteLine("AvgMark: " + StudAvgMark);
        }
        private int[] MarkList = new int[3];

        public Student()
        {
        }

        public int this[int index]
        {
            get { return MarkList[index]; }
            set { MarkList[index] = value; }
        }

        public void CalAvg()
        {
            float sum = 0;
            foreach (int mark in MarkList)
            {
                sum += mark;
            }
            StudAvgMark = sum / MarkList.Length;
        }


    }
}
