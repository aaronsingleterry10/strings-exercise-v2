using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringsExerciseV2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
            4 - Write a program and ask the user 
            to enter a few words separated by a space.
            Use the words to create a variable name 
            with PascalCase. For example, if the user 
            types: "number of students", display "NumberOfStudents".
            Make sure that the program is not dependent on the input. 
            So, if the user types "NUMBER OF STUDENTS", the program 
            should still display "NumberOfStudents".
            */
            //arrayInput[i] = arrayInput[i].Replace(arrayInput[i].Substring(0, 1), arrayInput[i].Substring(0, 1).ToUpper());

            //Console.Write("Enter a few words separated by a space: ");
            //var input = Console.ReadLine();
            //var arrayInput = input.Split(' ');
            //for (var i = 0; i < arrayInput.Length; i++)
            //{
            //    arrayInput[i] = arrayInput[i].ToLower();
            //    var letter = arrayInput[i].Substring(0, 1).ToUpper();
            //    var restOfWord = arrayInput[i].Substring(1);
            //    var newWord = letter + restOfWord;
            //    arrayInput[i] = newWord;
            //}

            //var newString = String.Join("", arrayInput);
            //Console.WriteLine(newString);

            /*
            5 - Write a program and ask the user to enter an 
            English word.Count the number of vowels(a, e, o, u, i) 
            in the word. So, if the user enters "inadequate", the program 
            should display 6 on the console.
            */
            Console.Write("Enter in an English word. ");
            var input = Console.ReadLine();
            string vowels = "aeiou";
            int count = 0;

            foreach (var item in input) 
            {
                if (vowels.IndexOf(item) >= 0)
                {
                    count++;
                }
            }
            Console.WriteLine(count);
        }
    }
}
