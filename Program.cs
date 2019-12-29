using System;


//Creating a sinple cipher program
namespace EzCypher
{
    class Program
    {
        static void Main(string[] args)

        {

            string preCode;  //The word to type into the cipher
            string word2Num;
            Console.WriteLine("Type in a word");
            preCode = Console.ReadLine();

            word2Num =  WordToNum(preCode, preCode.Length);
            Console.WriteLine("After the Cipher Function: ");
            Console.WriteLine(word2Num);
        }

        //This functions takes the letters of the word translates them to their number 
        public static string WordToNum(string ReadWord, int LenWord)
        {
            string wordNums ="";
            for (int i = 0; i < LenWord; i++ )
            {

                wordNums = wordNums + Cipher(((int)ReadWord[i]));
            }
           
            return wordNums;
        }
        public static char Cipher(int ciph)
        {
            //Creates a +5 ceaser cipher
            int inCipher;
            inCipher = (ciph + 5) % 127;  //makes the shift to the correct ascii number for the new letter
            return (char)inCipher; //returns the correct letter to the char
        }
    }
}
