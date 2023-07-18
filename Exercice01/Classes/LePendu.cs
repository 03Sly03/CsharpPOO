using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Channels;
using System.Threading.Tasks;

namespace Exercices.Classes
{
    internal class LePendu
    {
        private string _mask;
        private int _nbTry;
        private string _wordToFind;
        private int _nbEssaiMax = 10;

        public string Mask { get => _mask; set => _mask = value; }
        public int NbTry { get => _nbTry; set => _nbTry = value; }
        public string WordToFind { get => _wordToFind; set => _wordToFind = value; }
        public int NbEssaiMax { get => _nbEssaiMax; set => _nbEssaiMax = value; }

        public LePendu(int nbTry = 10)
        {
            _nbTry = nbTry;
            _wordToFind = WordGenerator.GenerateWord();
            _mask = string.Concat(Enumerable.Repeat("*", _wordToFind.Length));
        }   
        
        public int TestChar(string newChar)
        {
            NbTry--;
            if (_wordToFind.Contains(newChar))
            {
                int index = _wordToFind.IndexOf(newChar);
                return index;
            }
            return -1;
        }

        public string TestWin()
        {
            if (!_mask.Contains("*") && _nbTry >= 0)
            {
                return "win";
            }
            else if (NbTry <= 0)
            {
                return "loose";
            }
            return "onGame";
        }

        public void GenerateMask(string newChar = "", int isMatch = -1)
        {
            if (isMatch != -1)
            {
                _mask = _mask.Remove(isMatch, 1).Insert(isMatch, newChar.ToString());
            }
        }
    }
}
