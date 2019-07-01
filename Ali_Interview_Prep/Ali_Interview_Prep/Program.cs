using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;


namespace Ali_Interview_Prep
{

    class Program
    {
        static void Main(string[] args)
        {
            //reverseString("Hello World!");

            //checkPalindrome("madam");

            countCharacter("hello world");
        }

        // How to reverse a string?
        internal static void reverseString(string str)
        {
            char[] charArray = str.ToCharArray();

            for (int i = 0, j = str.Length - 1; i < j; i++, j--)
            {
                charArray[i] = str[j];
                charArray[j] = str[i];

            }

            string reversedString = new string(charArray);
            Console.WriteLine(reversedString);
        }

        // How to find if the given string is a palindrome or not?
        internal static void checkPalindrome(string str)
        {
            bool flag = false;

            for (int i = 0, j = str.Length - 1; i < str.Length /2; i++, j--)
            {
                if (str[i] != str[j])
                {
                    flag = false;
                    break;
                }
                else
                {
                    flag = true;
                }
            }

            if (flag)
            {
                Console.WriteLine("Palindrome!");
            }
            else
                Console.WriteLine("Not Palindrome");
        }

        // How to count the occurrence of each character in a string?
        internal static void countCharacter(string str)
        {
            Dictionary<char, int> characterCount = new Dictionary<char, int>();

            foreach (var character in str)
            {
                if (character != ' ')
                {
                    if (!characterCount.ContainsKey(character))
                    {
                        characterCount.Add(character, 1);
                    }
                    else
                    {
                        characterCount[character]++;
                    }
                }
            }

            foreach (var character in characterCount)
            {
                Console.WriteLine("{0} - {1}", character.Key, character.Value);
            }


        }


    }


}
