using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hackaton
{
    public class Scramble
    {
            public bool CompareScramble(string frase1, string frase2)
            {
                bool scrable = true;
                if (frase1.Length == frase2.Length)
                {
                    char[] lettersfrase1 = frase1.ToCharArray(); ;
                    char[] lettersfrase2 = frase2.ToCharArray(); ;
                    Array.Reverse(lettersfrase2);
                    for (int i = 0; i < lettersfrase1.Length; i++)
                    {
                        if (lettersfrase1[i] != lettersfrase2[i])
                        {
                        scrable = false;
                        }
                    }
                }
            else
                {
                    scrable = false;
                }
                return scrable;
            }
        }
}
