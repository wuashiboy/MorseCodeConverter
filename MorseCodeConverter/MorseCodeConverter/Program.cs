using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace MorseCodeConverter
{
    class Program
    {
        static void Main(string[] args)
        {
           
            var filePath = "MorseCode.csv";
            var newMorse = new Dictionary<char, string>();

            using (var sr = new StreamReader(filePath))
            {
                while (sr.Peek() > 0)
                {
                    var line = sr.ReadLine().Split(',');
                    var ALetter = Convert.ToChar(line[0]);

                    var Line = line[1];

                    newMorse.Add(ALetter, Line);
                }
                //}
                //foreach(var key in newMorse.Keys)
                //{
                //Console.WriteLine($"{key} , {newMorse[key]}");
                //Console.WriteLine($"for D Morse code is {newMorse['D']}");

                Console.WriteLine("Please type your message to be converted to Morse code");

                string inputstring = Console.ReadLine().ToUpper().Replace (" " , "");
                //var rv = newMorse;
                foreach (var ALetter in inputstring)
                {

                    var convertedLetter = newMorse[ALetter];
                    Console.Write(convertedLetter);
                }
                
            }
            
            Console.ReadLine();
        }
    }
}

