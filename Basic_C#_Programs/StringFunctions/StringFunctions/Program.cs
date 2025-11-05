using System;
using System.Text;

namespace StringFunctions
{
    class Program
    {
        static void Main(string[] args)
        {
            //Concatenation of several strings
            string nameHas = "Garrett has ";
            string whatHeHas = "a dog named ";
            string dogNameAndBreed = "Wicket, a blue and red heeler.";
            string fullSentence = string.Concat(nameHas, whatHeHas, dogNameAndBreed);
            Console.WriteLine(fullSentence);

            //Convert sting to upper case
            string upperCaseSentence = "boss tweed is a great software engineer.";
            upperCaseSentence = upperCaseSentence.ToUpper();
            Console.WriteLine(upperCaseSentence);

            //Creates a stringbuilder and builds a paragraph of text, one sentence at a time
            StringBuilder sb = new StringBuilder("I have had many careers in my life. ", 400);
            sb.AppendLine("I was in urban tree care, climbing and trimming trees for a couple years. ");
            sb.AppendLine("Then I worked as a private music instructor, while in college. ");
            sb.AppendLine("But I have finally found my lifelong career as a software developer.");
            Console.WriteLine(sb);
        }
    }
}