using Solution.BracketValidation;
using Solution.BrowserHistory;
using Solution.Palindrome;

namespace Solution;

internal class Program
{
    static void Main(string[] args)
    {
        // Browser history
        HistoryManager history = new HistoryManager();

        history.KunjungiHalaman("google.com");
        history.KunjungiHalaman("facebook.com");
        history.KunjungiHalaman("youtube.com");
        
        
        // Bracket validator
        BracketValidator validator = new BracketValidator();

        string[] brackets = {"[{}](){}", "([]{[]})[]{{}()}", "(]", "([)]", "{[}"};
        
        foreach (var bracket in brackets)
        {
            Console.WriteLine($"Ekspresi '{bracket}' valid? {validator.ValidasiEkspresi(bracket)}");
        }

        //Palindrome Checker
        string[] tests =
            {
                "Kasur ini rusak",
                "Ibu Ratna antar ubi",
                "Hello World"
            };

            foreach (string test in tests)
            {
                Console.WriteLine($"Input: \"{test}\" => Output: {PalindromeChecker.CekPalindrom(test)}");
            }
        }
    }

        

    
