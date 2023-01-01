using System;
using static System.Net.Mime.MediaTypeNames;

namespace summary_text
{
	public class StringUtilities
	{
		public StringUtilities()
		{
		}

		public static string summary_text(String text, int maxLength = 20)
		{

            var summaryList = new List<String>();

            if (text.Length < maxLength)
                return text;

            else
            {
                var wordList = text.Split(" ");
                var totalCount = 0;
                foreach (var word in wordList)
                {
                    summaryList.Add(word);

                    totalCount += word.Length + 1;
                    if (totalCount > maxLength)
                        break;

                }
            }
            return String.Join(" ", summaryList) + "...";
        }
	}
}

