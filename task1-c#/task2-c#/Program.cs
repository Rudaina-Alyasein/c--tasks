﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task2_c_
{
    internal class Program
       
    {
        static void  ConvertFunction(double num)
        {
           
            int x = (int)num;
            Console.WriteLine("Double is:" +num);
            Console.WriteLine("int number is:" + x);

        }
        static double convert_K(double kilometers)
        {
            return kilometers * 0.621371;
        }
        static int getMinutes(int hours, int minutes)
        {
            return (hours * 60) + minutes;
        }
        static void Total_hours(int min)
        {
            int hours = min / 60;
            int minutes = min % 60;
            Console.WriteLine(hours + "Hours" + "," + minutes + "Minutes");
        }

        static void  middle(int[] arr)
        {

           Array.Sort(arr);
            int n = arr.Length;

                int mid = arr[arr.Length / 2];
                Console.WriteLine("the middle number i :"+mid);
            

        }
        static string IsDivisible(int num1,int num2)
        {
            if (num1 % num2 == 0)
            {
                return "divisible";
            }
            else
            {
                return "not divisible";
            }
        }
        
        static void Main(string[] args)
        {
            //1
            ConvertFunction(12.4);
            //2
            int num = 25;
            string concat_num = Convert.ToString(num);
            Console.WriteLine("your number is :" + num);
            //3 
            Console.WriteLine("plz insert string and convert it to lower and upper case");
            string text = Console.ReadLine();
            Console.WriteLine("the text in upper case is :" + text.ToUpper());
            Console.WriteLine("the text in lower case is :" + text.ToLower());
            //4 
            Console.WriteLine("plz insert your full name");
            string Fullname = Console.ReadLine();
            Console.WriteLine("the first name is :" + Fullname.Substring(0,7));
            Console.WriteLine("the last name is :" + Fullname.Substring(8));
            Console.WriteLine("the length of full name is :" + Fullname.Length);
            //5
            Console.WriteLine("plz insert two number and print the smallest:");
            int num1 = int.Parse(Console.ReadLine());
            int num2 = int.Parse(Console.ReadLine());
            int smallest_num;
            if (num1 < num2)
            {
                smallest_num = num1;
            }
            else
            {
                smallest_num = num2;
            }
            Console.WriteLine("the smallest num is :" + smallest_num);

            //6
            Console.WriteLine("the value from kilometers to miles:" + convert_K(2000));

            //7
            Console.WriteLine("Total Minutes are:" + getMinutes(3,15));
            //8
            Total_hours(546);
            //9
            string Digits = "123";
            int SumOfDigits = 0;
            foreach (char digit in Digits) {
                int digit1 = digit - '0'; 
                SumOfDigits += digit1;
            }

 
            Console.WriteLine("the sum of digits is :" + SumOfDigits);

            //10 
            string number = "1234";
            string number2=" ";
            for (int i=number.Length-1; i >=0; i--)
            {
                number2 += number[i];


            }
            Console.WriteLine("the string after reversed is :"+number2);
            //11
            Console.WriteLine(IsDivisible(4, 3));
            //12
            int[] numbers = { 15, 20, 10 };
            middle(numbers);
             
       

        }
    }
}
