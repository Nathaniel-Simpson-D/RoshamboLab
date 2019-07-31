﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;





namespace RoshmboApp
{
    public class Validator
    {
        public static double GetValidDouble(string message)
        {
            Console.WriteLine(message);
            string input = Console.ReadLine();

            bool isValid = double.TryParse(input, out double result);
            if (isValid /*&& result > 0*/)
            {
                return result;
            }
            /*else if (isValid)
            {
                return ValidateDouble("Please enter a value GREATER THAN 0.00");
            }*/
            else
            {
                //Console.WriteLine("(FormatException)");
                return GetValidDouble($"{input} is Not Valid!");
            }
        }
        public static bool GetYN(string message)
        {
            Console.WriteLine(message + "(Y/N)");
            ConsoleKeyInfo key = Console.ReadKey(true);
            if (key.Key == ConsoleKey.Y)
            {
                return true;
            }
            else if (key.Key == ConsoleKey.N)
            {
                return false;
            }
            else
            {
                return GetYN("Not Valid!");
            }
        }
        public static int GetIntChoice(int min, int max)
        {
            // takes in human # outputs index/computer #
            string input = Console.ReadLine();
            bool isValid = int.TryParse(input, out int ChV);

            if (!isValid)
            {
                Console.WriteLine("Not Valid, Please enter an Interger");
                return GetIntChoice(min, max);
            }
            else if (ChV >= min && ChV <= max)
            {
                return ChV - 1;
            }
            else
            {
                Console.WriteLine($"Not Valid, {ChV} is not within the range {min}-{max}!");
                return GetIntChoice(min, max);
            }
        }
        public static int GetRPSChoice()
        {
            // takes in human # outputs index/computer #
            string input = Console.ReadLine().ToLower().Trim();
            int.TryParse(input, out int ChV);

            
            
            if ("rock" == input.ToLower()|| ChV == 1)
            {
                return (int)Roshambo.Rock;
            }
            else if("paper" == input.ToLower() || ChV == 2)
            {
                return (int)Roshambo.Paper;
            }
            else if ("scissors" == input.ToLower() || ChV == 3)
            {
                return (int)Roshambo.Scissors;
            }
            else
            {
                Console.WriteLine("Not Valid, Please enter an Interger(1-3) or valid choice");
                return GetRPSChoice();
            }
        }
        public static DateTime GetValidDate(string message)
        {
            Console.WriteLine(message);
            Console.WriteLine("Format as DD/MM/YYYY");
            string input = Console.ReadLine();
            bool isValid = DateTime.TryParse(input, out DateTime date);
            if (isValid)
            {
                return date;
            }
            else
            {
                return GetValidDate("Not Valid!");
            }
        }
        public static string GetValidName(string message)
        {
            Console.WriteLine(message);
            string input = Console.ReadLine();
            if (Regex.IsMatch(input, @"^(([A-Z]{1}\w{2,29}\s{0,1}[A-Z]{0,1}[a-z]{0,29}))$"))
            {
                return input;
            }
            else
            {
                return GetValidName("Not Valid!");
            }
        }
        public static string GetValidString(string message)
        {
            Console.WriteLine(message);
            string result = Console.ReadLine();
            
            if (result != null && result != " " && result != "")
            {
                return result;
            }
            else
            {
                return GetValidString("Not Valid!");
            }
        }
        public static void EndProgram(string message)
        {
            Console.WriteLine(message);
            Console.WriteLine("press ESC to exit");
            while (Console.ReadKey(true).Key != ConsoleKey.Escape)
            { }
            // System.Environment.Exit(0); closes program
            System.Environment.Exit(0); 
        }
        public static bool VerifyPassword(string gateWord)
        {
            Console.WriteLine("Press enter to submit password, pressing ESC will close program.");
            System.Console.Write("Enter password: ");
            string password = null;
            while (true)
            {
                System.ConsoleKeyInfo input = System.Console.ReadKey(true);
                if (input.Key == ConsoleKey.Enter)
                {
                    break;
                }
                else if (input.Key == ConsoleKey.Escape)
                {
                    System.Environment.Exit(0);
                }
                else if (input.Key == ConsoleKey.Backspace)
                {
                    password = password.Remove(password.Length - 1);
                    Console.Write("\b \b");

                }
                else
                {
                    password += input.KeyChar;
                    Console.Write("X");
                }
            }
            Console.WriteLine("");
            if (gateWord.Equals(password))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}

