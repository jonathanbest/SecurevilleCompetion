using System;
using System.Collections.Generic;
using System.Reflection.PortableExecutable;
using System.Text;

namespace SecurevilleComp
{
    public class CaesarShiftCipher
    {
        public char ConvertChar(char inputValue)
        {
            if (!IsValidInput(inputValue))
                return inputValue;

            int value = inputValue;

            value += OffSet;

            //if the new value is outside the bounds then adjust
            if (value < 'A')
            {
                value += 26;
            }
            else if (value > 'Z')
            {
                value -= 26;
            }

            return (char)value;
        }

        private static bool IsValidInput(char inputChar)
        {
            return char.IsLetter(inputChar) && char.IsUpper(inputChar);
        }

        public int OffSet { get; set; }
    }
}
