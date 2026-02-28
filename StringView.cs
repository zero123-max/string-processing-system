using System;
using Processing.Services;

namespace Processing.Views
{
    public class StringView
    {
        private string stringService;
         
        public StringView()
        {
            stringService = new StringService();
        }
        
        public void showMenu()
        {
            while(true)
            {
                Console.WriteLine("---BSCS INTERNETAN PROCESSING SYSTEM---");
                Console.WriteLine("1. Enter text.");
                Console.WriteLine("2. View Current text.");
                Console.WriteLine("3. Convert to upper case.");
                Console.WriteLine("4. Convert to lower case");
                Console.WriteLine("5. Count Characters.");
                Console.WriteLine("6. Check if contains words.");
                Console.WriteLine("7. Replace word.");
                Console.WriteLine("8. Extract substring.");
                Console.WriteLine("9. Trim spaces. ");
                Console.WriteLine("10. Reset text.");
                Console.WriteLine("11. Exit");
                Console.WriteLine("Choose an option: ");
                string choice = Console.ReadLine();
                
                switch(choice)
                {
                    case "1":
                        EnterText();
                        break;
                    case "2":
                        ViewCurrentText();
                        break;
                    case "3":
                        ConvertToUpper();
                        break;
                    case "4":
                        ConvertToLower();
                        break;
                    case "5":
                        CountCharacters();
                        break;
                    case "6":
                        CheckIfContainsWord();
                        break
                    case "7":
                        ReplaceWord();
                        break;
                    case "8":
                        ExtractSubstring();
                        break;
                    case "9":
                        TrimSpaces();
                        break
                    case "10":
                        ResetText();
                        break
                    case "11":
                        Exit();
                        return;
                    default:
                        Console.WriteLine("!!!INVALID OPTION!!! PLEASE TRY AGAIN!!");
                        break;
                }
            }
        }
        
        private void EnterText()
        {
            Console.WriteLine("Enter text: ");
            string text = Console.ReadLine();
            stringService.setText(text);
            Console.WriteLine("Text has been set.");
            Console.ReadKey();
        }
        
        private void ViewCurrentText()
        {
            Console.WriteLine("Current text: " + stringService.CurrentText);
            Console.ReadKey();
        }
        
        private void ConvertToUpper()
        {
            Console.WriteLine("Text in upper case: " + stringService.ConvertToUpper());
            Console.ReadKey();
        }
        
        private void ConvertToLower()
        {
            Console.WriteLine("Text in lower case: " + stringService.ConvertToLower());
            Console.ReadKey();
        }
        
        private void CountCharacters()
        {
            Console.WriteLine("Character Count: " + stringService.CountCharacters());
            Console.ReadKey();
        }
        
        private void CheckIfContainsWord()
        {
            Console.WriteLine("Enter word to check: ");
            string word = Console.ReadLine();
            if(stringService.ContainsWord())
            {
                Console.WriteLine($"The text contains the word '{word}'.");
            }
            else
            {
                Console.WriteLine($"The text does not contain the word '{word}'.");
            }
            Console.ReadKey();
        }
        
        private void ReplaceWord()
        {
            Console.WriteLine("Enter word to replace: ");
            string oldWord = Console.ReadLine();
            Console.WriteLine("Enter new word: ");
            string newWord = Console.ReadLine();
            Console.WriteLine("Updated Text: " + stringService.ReplaceWord(oldWord, newWord));
            Console.ReadKey();
        }
        
        private void ExtractSubstring()
        {
            Console.WriteLine("Enter starting index: ");
            int startIndex = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter length of substring: ");
            int length = int.Parse(Console.ReadLine());
            Console.WriteLine("Substring: " + stringService.ExtractSubstring(startIndex, length));
            Console.ReadKey();
        }
        
        private void TrimSpaces()
        {
            Console.WriteLine("Text afte trim: " + stringS
