using System;
using System.Linq;
namespace PalindromeExercise
{
    public class WordSmith
    {
        public bool IsAPalindrome(string word) //to start scope, look at return type
        {
            var reversedWord = word.Reverse();
            return word.ToLower().SequenceEqual(reversedWord); /* Determine whether two
            sequences are equal by returning the reverse */

            //var reversed = "";
            //for(int i = word.Length - 1; i >= 0; i--) // start at end of word, write backwards
            //{
              //  reversed += word[i]; // print each letter of word
            //}
            //if(reversed.ToLower() == word.ToLower())
            //{
              //  return true;
            //}
            //return false;
            // reverse the word
            // compare the original with reversed word
            // return whether they're the same
        }
    }
}
