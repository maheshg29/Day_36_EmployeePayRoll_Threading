using System.Net;
using System.Text;

namespace Day_36_EmployeePayRoll_Threading
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] words = CreateWordArray(@"http://www.gutenberg.org/files/54700/54700-0.txt");
            Parallel.Invoke(() =>
            {
                Console.WriteLine("Begin first task...");
                GetLongestWord(words);
            },
            () =>
            {
                Console.WriteLine("Begin second task...");
                GetMostCommonWords(words);
            },
            () =>
            {
                Console.WriteLine("Begin third task...");
                GetCountForWords(words, "sleep");
            }
            );
            Console.WriteLine("Returned from Parallel.Invoke");
        }

        private static void GetCountForWords(string[] words, string term)
        {
            var findWord = from word in words where word.ToUpper().Contains(term.ToUpper()) select word;

            Console.WriteLine($@"Task 3--The word ""{term}"" occurs {findWord.Count()} times.");
        }

        private static void GetMostCommonWords(string[] words)
        {
            var frequencyOrder = from word in words
                                 where word.Length > 6
                                 group word by word into g
                                 orderby g.Count() descending
                                 select g.Key;

            var commonWords = frequencyOrder.Take(10);

            StringBuilder sb = new StringBuilder();
            sb.AppendLine("Task 2 -- The most common words are:");
            foreach (var v in commonWords)
            {
                sb.AppendLine("  " + v);
            }
            Console.WriteLine(sb.ToString());
        }
        private static string GetLongestWord(string[] words)
        {
            var longestWord = (from w in words
                               orderby w.Length descending
                               select w).First();

            Console.WriteLine($"Task 1 -- The longest word is {longestWord}.");
            return longestWord;
        }

        static string[] CreateWordArray(string uri)
        {
            Console.WriteLine($"Retrieving from {uri}");
            string s = new WebClient().DownloadString(uri);
            return s.Split(new char[] { ' ', '\u000A', ',', '.', ';', ':', '-', '_', '/' }, StringSplitOptions.RemoveEmptyEntries);
        }
    
    }
}