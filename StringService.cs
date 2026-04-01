using System;

namespace StringProcessingApp.Services
{
    public class StringService
    {
        private string currentText = "";
        private string originalText = "";

        public void SetText(string text)
        {
            currentText = text;
            originalText = text;
        }

        public string GetText()
        {
            return currentText;
        }

        public void ToUpperCase()
        {
            currentText = currentText.ToUpper();
        }

        public void ToLowerCase()
        {
            currentText = currentText.ToLower();
        }

        public int CountCharacters()
        {
            return currentText.Length;
        }

        public bool ContainsWord(string word)
        {
            return currentText.Contains(word);
        }

        public void ReplaceWord(string oldWord, string newWord)
        {
            currentText = currentText.Replace(oldWord, newWord);
        }

        public void ExtractSubstring(int startIndex, int length)
        {
            if (startIndex >= 0 && startIndex + length <= currentText.Length)
            {
                currentText = currentText.Substring(startIndex, length);
            }
            else
            {
                Console.WriteLine("Invalid substring range.");
            }
        }

        public void TrimSpaces()
        {
            currentText = currentText.Trim();
        }

        public void ResetText()
        {
            currentText = originalText;
        }
    }
}
