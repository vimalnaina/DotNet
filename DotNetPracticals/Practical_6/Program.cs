﻿/* Practical 5
 * Write a C# code to convert digits to words 
 */

using System;

namespace Practical_5
{
    class Program
    {
        static void Main(string[] args)
        {
            String number, result;
            Console.Write("Please enter the number : ");
            number = Console.ReadLine();
            result = ConvertoNumber(number);
            Console.Write("\n Number in words : ");
            Console.WriteLine(result);
            Console.Read();
        }

        public static String ones(String Number)
        {
            int _Number = Convert.ToInt32(Number);
            String name = "";
            switch (_Number)
            {

                case 1:
                    name = "One";
                    break;
                case 2:
                    name = "Two";
                    break;
                case 3:
                    name = "Three"; 
                    break;
                case 4:
                    name = "Four";
                    break;
                case 5:
                    name = "Five";
                    break;
                case 6:
                    name = "Six";
                    break;
                case 7:
                    name = "Seven";
                    break;
                case 8:
                    name = "Eight";
                    break;
                case 9:
                    name = "Nine";
                    break;
            }
            return name;
        }
        public static String tens(String Number)
        {
            int _Number = Convert.ToInt32(Number);
            String name = null;
            switch (_Number)
            {
                case 10:
                    name = "Ten";
                    break;
                case 11:
                    name = "Eleven";
                    break;
                case 12:
                    name = "Twelve";
                    break;
                case 13:
                    name = "Thirteen";
                    break;
                case 14:
                    name = "Fourteen";
                    break;
                case 15:
                    name = "Fifteen";
                    break;
                case 16:
                    name = "Sixteen";
                    break;
                case 17:
                    name = "Seventeen";
                    break;
                case 18:
                    name = "Eighteen";
                    break;
                case 19:
                    name = "Nineteen";
                    break;
                case 20:
                    name = "Twenty";
                    break;
                case 30:
                    name = "Thirty";
                    break;
                case 40:
                    name = "Fourty";
                    break;
                case 50:
                    name = "Fifty";
                    break;
                case 60:
                    name = "Sixty";
                    break;
                case 70:
                    name = "Seventy";
                    break;
                case 80:
                    name = "Eighty";
                    break;
                case 90:
                    name = "Ninety";
                    break;
                default:
                    if (_Number > 0)
                    {
                        name = tens(Number.Substring(0, 1) + "0") + " " + ones(Number.Substring(1));
                    }
                    break;
            }
            return name;
        }
        public static String ConvertoNumber(String Number)
        {
            string word = "";
            try
            {
                bool isDone = false;//test if already translated    
                int n = Convert.ToInt32(Number);
                if (n > 0)
                {
                    int numDigits = Number.Length;
                    int pos = 0;   //store digit grouping    
                    String place = "";    //keywords like hundres,thousand...  
                    switch (numDigits)
                    {
                        case 1:  //ones' range    
                            word = ones(Number);
                            isDone = true;
                            break;
                        case 2:  //tens' range    
                            word = tens(Number);
                            isDone = true;
                            break;
                        case 3:  //hundreds' range    
                            pos = (numDigits % 3) + 1;
                            place = " Hundred ";
                            break;
                        case 4://thousands' range    
                        case 5:
                            pos = (numDigits % 4) + 1;
                            place = " Thousand ";
                            break;
                        case 6:
                        case 7://millions' range 
                            pos = (numDigits % 6) + 1;
                            place = " Lakh ";
                            break;
                        case 8:
                        case 9:
                            pos = (numDigits % 8) + 1;
                            place = " Crore ";
                            break;
                        case 10://Billions's range    
                        case 11:
                            pos = (numDigits % 10) + 1;
                            place = " Billion ";
                            break;
                        default:
                            isDone = true;
                            break;
                    }
                    if (!isDone)
                    {
                        //Recursion call    
                        if (Number.Substring(0, pos) != "0" && Number.Substring(pos) != "0")
                        {
                            try
                            {
                                word = ConvertoNumber(Number.Substring(0, pos)) + place + ConvertoNumber(Number.Substring(pos));
                            }
                            catch
                            { }
                        }
                        else
                        {
                            word = ConvertoNumber(Number.Substring(0, pos)) + ConvertoNumber(Number.Substring(pos));
                        }
                    }
                }
            }
            catch { }
            return word;
        }
    }
}
