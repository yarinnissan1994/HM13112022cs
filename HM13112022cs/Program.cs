using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW_13112022
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Contains
            //CopyTo 
            //Insert 
            //PadRight 
            //Replace 
            //SubString 
            //ToCharArray 
            //Split 
            //Trim 
            //TrimStart 
            //StartWith 
            //IndefOf 

            // ****Contains**** - this functions check if a string conatins a sub string inside and returns boolean

            Console.WriteLine("~ Contains function ~");
            String strContains = "pizza";
            Console.WriteLine("sub string: " + strContains);
            String strContains1 = "i love pizza";
            Console.WriteLine("string 1: " + strContains1);
            String strContains2 = "i love pasta";
            Console.WriteLine("string 2: " + strContains2);
            bool result1 = strContains1.Contains(strContains);
            bool result2 = strContains2.Contains(strContains);
            Console.WriteLine("sub string excist in string 1: " + result1);
            Console.WriteLine("sub string does not exist in string 2: " + result2);
            Console.WriteLine();

            // ****CopyTo**** - taking a part from a string and copy it to array;

            Console.WriteLine("~ CopyTo function ~");
            String strCopyTo = "we vibe, we move";
            Console.WriteLine("full string: ");
            Console.WriteLine(strCopyTo);
            char[] CopyTo = new char[7];
            // CopyTo(index (source) , destenation, start index (destenation), count to copy)
            strCopyTo.CopyTo(9, CopyTo, 0, 7);
            Console.WriteLine("after copied the sub string to new one: ");
            Console.WriteLine(CopyTo);
            Console.WriteLine();

            // ****Insert**** - inserts a sub string inside a string (Insert(index, "new sub string"))

            Console.WriteLine("~ Insert function ~");
            String strInsert = "coca-cola";
            Console.WriteLine("original string: " + strInsert);
            Console.WriteLine("new string 1: " + strInsert.Insert(0, "diet "));
            Console.WriteLine("new string 2: " + strInsert.Insert(9, " zero"));
            Console.WriteLine();

            // ****PadRight**** - allow us to do padding to the right of the string (PadRight(total width, padding char))

            Console.WriteLine("~ PadRight function ~");
            String strPadRight = "hot water, small glass";
            char Pad = '*';
            Console.WriteLine("oroginal string: " + strPadRight);
            Console.WriteLine("padding exemple 1: " + strPadRight.PadRight(40) + "after padding");
            Console.WriteLine("padding exemple 2: " + strPadRight.PadRight(40, Pad) + "after padding");
            Console.WriteLine();

            // ****Replace**** - allow us to swap old value to new one (replace(old value, new value))

            Console.WriteLine("~ Replace function ~");
            String strReplace = "i hate playing outside";
            Console.WriteLine("oroginal string: " + strReplace);
            Console.WriteLine("string after value replaced: " + strReplace.Replace("hate", "love"));
            Console.WriteLine();

            // ****SubString**** - allowes you to take just apart of a string (SubString(index (start), char count))

            Console.WriteLine("~ SubString function ~");
            String strSubString = "a whole new world";
            Console.WriteLine("oroginal string: " + strSubString);
            Console.WriteLine("example 1: " + strSubString.Substring(8));
            Console.WriteLine("example 2: " + strSubString.Substring(2, 9));
            Console.WriteLine();

            // ****ToCharArray**** - allowes you to take charecter by index into an array (ToCharArray(index (start), char count))

            Console.WriteLine("~ ToCharArray function ~");
            String strToCharArray = "hakunna matata, it means no worries";
            char[] array;
            array = strToCharArray.ToCharArray(0, 14);
            Console.WriteLine("oroginal string: " + strToCharArray);
            Console.Write("example 1: ");
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write(array[i]);
            }
            array = strToCharArray.ToCharArray(16, 19);
            Console.Write("\nexample 2: ");
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write(array[i]);
            }
            Console.WriteLine("\n");

            // ****Split**** - allowes you to split a string by char seperator into an array (Split(seperator))

            Console.WriteLine("~ Split function ~");
            String strSplit = "let`s get it started";
            string[] words = strSplit.Split(' ');
            Console.WriteLine("oroginal string: " + strSplit);
            Console.WriteLine("split words array: ");
            for (int i = 0; i < words.Length; i++)
            {
                Console.WriteLine(words[i]);
            }
            Console.WriteLine();

            // ****Trim**** - allowes you to remove unwanted charecters in string from before start and after the end (Trim(array of unwanted chars to remove))

            Console.WriteLine("~ Trim function ~");
            String strTrim = ",,,,you are stronger than ever****";
            char[] remove = { '*', ',', ' ' };
            Console.WriteLine("oroginal string: " + strTrim);
            Console.WriteLine("example: " + strTrim.Trim(remove));
            Console.WriteLine();

            // ****TrimStart**** - allowes you to remove unwanted charecters in string from before start(Trim(array of unwanted chars to remove))

            Console.WriteLine("~ TrimStart function ~");
            String strTrimStart = "$$$$peace and love";
            Console.WriteLine("oroginal string: " + strTrimStart);
            Console.WriteLine("example: " + strTrimStart.TrimStart('$'));
            Console.WriteLine();

            // ****StartsWith**** - enter a sub string and the start with method will check if strings starts with it (returns boolean)

            Console.WriteLine("~ StartsWith function ~");
            String strStartsWith = "me, myself and i";
            Console.WriteLine("oroginal string: " + strStartsWith);
            Console.WriteLine("if start with the sub string: " + strStartsWith.StartsWith("me"));
            Console.WriteLine("if does not start with sub string: " + strStartsWith.StartsWith("myself"));
            Console.WriteLine();

            // ****IndexOf**** - enter a sub string and get the index of it in a string (if does not excist returns -1)

            Console.WriteLine("~ IndexOf function ~");
            String strIndexOf = "curiosity killed the cat";
            Console.WriteLine("oroginal string: " + strIndexOf);
            Console.WriteLine("index of the word \"killed\": " + strIndexOf.IndexOf("killed"));
            Console.WriteLine();

            Console.ReadLine();
        }
    }
}
