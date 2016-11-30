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
                    var Aletter = Convert.ToChar(line[0]);
                    var Line = line[1];

                    newMorse.Add(Aletter, Line);
                }
                //}
                //foreach(var key in newMorse.Keys)
                //{
                //Console.WriteLine($"{key} , {newMorse[key]}");
                //Console.WriteLine($"for D Morse code is {newMorse['D']}");

                Console.WriteLine("Please enter your message that you would like to be converted into Morse code");

                string inputstring = Console.ReadLine().ToString().ToUpper().Replace(" ", "");
                var converted = string.Empty;
                foreach (var Aletter in inputstring)
                {

                    var convertedLetter = newMorse[Aletter];
                    converted += convertedLetter;
                    Console.Write(convertedLetter);

                }

                //var sw = new StreamWriter("ReadIn.csv");
                //sw.Close();

                var now = inputstring.ToString();
                var textpath = "ReadIn.csv";

                using (var SW = File.AppendText(textpath))
                {
                    SW.WriteLine(now);
                    SW.WriteLine(converted);
                }
                
            }
            {
                Console.WriteLine();
                
                var DoitAgain = true;
                while (DoitAgain)
                {
                    Console.WriteLine("Would you like to convert another message: y/n" + "?");
                    var answer = Console.ReadLine();
                    if (answer == "y")

                    {
                        Console.WriteLine("Please enter another message:");
                        string inputstring = Console.ReadLine().ToString().ToUpper().Replace(" ", "");
                        var converted = string.Empty;
                        foreach (var Aletter in inputstring)
                        {

                            var convertedLetter = newMorse[Aletter];
                            converted += convertedLetter;
                            Console.Write(convertedLetter);

                        }

                        var now = inputstring.ToString();
                        var textpath = "ReadIn.csv";

                        using (var SW = File.AppendText(textpath))
                        {
                            SW.WriteLine(now);
                            SW.WriteLine(converted);
                        }
                        continue;
                                                    
                    }
                    else if (answer == "n")
                    {
                        break;
                    }
                }
                
            }
            Console.ReadLine();

        }
        
    }

}

