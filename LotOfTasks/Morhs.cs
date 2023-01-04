using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace LotOfTasks
{
    class Morhs
    {
        Dictionary<char, string> Alphabet;
       public Morhs()
        {
            Alphabet = new Dictionary<char, string>()
            {
                {'A', ".-"},      {'B', "-..." },
                {'C', "-.-."},   {'D', "-.."},
                {'E', "."},         {'F', "..-."},
                {'G', "--."},     {'H', "...."},
                {'I', ".."},       {'J', ".---"},
                {'K', "-.-"},     {'L', ".-.."},
                {'M', "--"},       {'N', "-."},
                {'O', "---"},     {'P', ".--."},
                {'Q', "--.-"},   {'R', ".-."},
                {'S', "..."},     {'T', "-"},
                {'U', "..-"},     {'V', "...-"},
                {'W', ".--"},     {'X', "-..-"},
                {'Y', "-.--"},   {'Z', "--.."},
            };
        }
       public string Encrypting(string wordToEncrypt)
        {
            string wordInMorhse = "";
            foreach (var item in wordToEncrypt)
            {
                if (item != ' ')
                    wordInMorhse += Alphabet[item] + " ";
                else
                    wordInMorhse += "/";
            }
            return wordInMorhse;
        }
        public void BeepBepBeeep(string wordToBeep)
        {
            Thread.Sleep(2000);
            foreach (var item in Encrypting(wordToBeep))
            {
                switch(item)
                {
                    default:
                    case ' ':
                    {
                            //Thread.Sleep(2000);
                            break;
                    }
                    case '-':
                    {
                            Console.Beep(30000, 3000);
                            break;
                    }
                    case '.':
                    {
                            Console.Beep(30000, 1000);
                            break;
                    }
                }
                Thread.Sleep(1000);
            }
        }
    }
}
