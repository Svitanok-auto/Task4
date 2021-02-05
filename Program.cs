using System;

namespace ConsoleApp4

{

    public class Program
    {

        public static void Main(string[] args)

        {
            Console.WriteLine("What is the String");
            int i = 0;

            while (i < 10)
            {

                string InputString = Console.ReadLine();

                if (InputString.ToString() != string.Empty) // the Convert fails when ""
                {
                    try
                    {

                        char[] chars = InputString.ToCharArray();
                    //  Console.WriteLine("Success"); // just a check
                        string str1 = new string(chars);
                        int length = str1.Length;
                        Console.WriteLine("Length: " + length);
                        bool result = Char.IsDigit(chars[0]);

                        if (result == true)  // if the first character is a nuber show "Not Palindrome"
                            {
                                Console.WriteLine("The word is NOT a palindrome; Try again ");
                            }
                            else
                            {
                                int u = 0;
                                while ((chars[u] == chars[length - 1 - u]) && (u < (length - 1) / 2) && (length > 2) && (length % 2 != 0)&& (Char.IsDigit(chars[u])==false) && (Char.IsDigit(chars[u+1]) == false)) //the main check if the word is a palindrome
                                {
                                    u = u + 1;
                                }

                                if (u == (((length - 1) / 2)) && (length > 2) && (length % 2 != 0))
                                {
                                    Console.WriteLine("The word is a Palindrome; Try again ");
                                }
                                else
                                {
                                    Console.WriteLine("The word is NOT a palindrome; Try again ");
                                }
                          
                            }
                       
                    }
                    catch (SystemException sex)
                    {
                        // this class's error string
                        string LastError = sex.Message;
                        Console.WriteLine("Incorrect Input, error" + LastError);
                        Console.WriteLine("Try again to populate a word");

                    }

                }

                else
                {
                    Console.WriteLine("Empty input, try again");
                }
            }

        }

    }
}
