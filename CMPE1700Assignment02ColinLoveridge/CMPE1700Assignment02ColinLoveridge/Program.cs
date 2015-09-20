using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ColinLoveridgeMethodLibrary;
using System.Text.RegularExpressions;

namespace CMPE1700Assignment02ColinLoveridge
{
    class Program
    {
        static void Main(string[] args)
        {
            
            int count = 0;
            string letters = string.Empty;
            string response = null;
            int number = 0;
            Console.WriteLine("Enter a phrase with the form of - N phrase you want - where N is the number of times you want the phrase printed.");//explination
            do//for repeating if error
            {
                response = Console.ReadLine();//get response
                foreach (char c in response)//searches each character
                {
                    if (Char.IsLetter(c) || Char.IsWhiteSpace(c) || Char.IsPunctuation(c))//if it is a letter, space or puncation adds it to a new string
                    {
                        letters += c;
                    }
                    if (Char.IsNumber(c))//if it is a number parses the string for a number doesn't matter if multiple numbers because it just sets the value to the same everytime
                    {
                        number = Convert.ToInt32(System.Text.RegularExpressions.Regex.Match(response, @"\d+").Value);
                    }
                }
                if (number == 0)//The number is defaulted to 0 so if there is no number the number will be zero producing error 
                {
                    Console.WriteLine("You have not entered a digit before your phrase or your digit was 0. Please try again");
                }
                else//if number is not 0 it moves on to a loop of printing with a count to keep track of times it has gone through the loop
                {
                    do
                    {
                        Console.WriteLine("{0}", letters);
                        count = count + 1;
                    } while (count != number); //stops when the # of loops = to # in the string
                }
                letters = null; //nulls the strings so that if you only type letters it doesn't come up later
                response = null;
            } while (number == 0);//repeats if number is 0 so user can try again
            MyMethods.Pause();
        }
    }
}
