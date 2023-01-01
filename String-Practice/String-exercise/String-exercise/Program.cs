internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");
        //Write a program and ask the user to enter a few numbers separated by a hyphen. Work out if the numbers are consecutive.
        //For example, if the input is "5-6-7-8-9" or "20-19-18-17-16", display a message: "Consecutive"; otherwise, display "Not Consecutive".

        Console.WriteLine("Enter the hypen seperated numbers eg,1-2-3-4-5");
        var userInput = Console.ReadLine();
        var splitHypens = userInput.Split("-");
        var isConsecutive = true;

        int innerCounter = 0;
        for (var i = Convert.ToInt32(splitHypens[0]); i <= Convert.ToInt32(splitHypens[splitHypens.Length - 1]); i++)
        {
            if (Convert.ToInt32(splitHypens[innerCounter]) == i)
            {
                isConsecutive = true;
                innerCounter++;
            }
            else
            {
                isConsecutive = false;
                break;
            }

        }

        if (isConsecutive)
            Console.WriteLine("Concecutive number");
        else
            Console.WriteLine("Not a Concecutive number");



        //Write a program and ask the user to enter a few numbers separated by a hyphen. If the user simply presses Enter,
        //without supplying an input, exit immediately; otherwise,
        //check to see if there are duplicates. If so, display "Duplicate" on the console.
        Console.WriteLine("Enter the hypen seperated numbers eg,1-2-3-4-5");

        var userInput1 = Console.ReadLine();
        if (!String.IsNullOrWhiteSpace(userInput1))
        {
            var splitHypens1 = userInput1.Split("-");
            for (var i = 0; i < splitHypens1.Length; i++)
            {
                bool loopEnd = false;
                for (var j = i + 1; j < splitHypens1.Length; j++)
                {
                    if (splitHypens1[i] == splitHypens1[j])
                    {
                        loopEnd = true;
                        break;
                    }

                }
                if (loopEnd)
                {
                    Console.WriteLine("Duplicate");
                    break;
                }
            }

        }


        //Write a program and ask the user to enter an English word.
        //Count the number of vowels (a, e, o, u, i) in the word.
        //So, if the user enters "inadequate", the program should display 6 on the console.

        var englishWord = Console.ReadLine();
        var vowelCount = 0;
        foreach (var character in englishWord)
        {
            if (character == 'a' || character == 'e' || character == 'i' || character == 'o' || character == 'u')
                vowelCount += 1;
        }

        Console.WriteLine("Vowel Count in {0} is {1}", englishWord, vowelCount);


        //Write a program and ask the user to enter a few words separated by a space.
        //Use the words to create a variable name with PascalCase. For example, if the user types: "number of students", display "NumberOfStudents".
        //Make sure that the program is not dependent on the input.
        //So, if the user types "NUMBER OF STUDENTS", the program should still display "NumberOfStudents"

        var sentence = Console.ReadLine();
        var splitIntoWord = sentence.Split(" ");
        var resultPascalWord = new List<String>();
        foreach (var word in splitIntoWord)
        {
            resultPascalWord.Add(word.First().ToString().ToUpper() + word.Substring(1).ToLower());
        }
        Console.WriteLine("PascalCase Notation for given sentence is : {0}", String.Join("", resultPascalWord));


        //Write a program and ask the user to enter a time value in the 24-hour time format (e.g. 19:00).
        //A valid time should be between 00:00 and 23:59. If the time is valid, display "Ok"; otherwise, display "Invalid Time".
        //If the user doesn't provide any values, consider it as invalid time.
        Console.WriteLine("Enter Time in 24hrs format eg, 12:54");

        var timeInput = Console.ReadLine();

        if (!String.IsNullOrWhiteSpace(timeInput))
        {
            var splitTime = timeInput.Split(":");
            if ((Convert.ToInt32(splitTime[0]) >= 0 && Convert.ToInt32(splitTime[0]) <= 23)
                &&
                (Convert.ToInt32(splitTime[0]) >= 0 && Convert.ToInt32(splitTime[0]) <= 59)
                )
            {
                Console.WriteLine("OK");
            }
            else
            {
                Console.WriteLine("Invalid Time");
            }
        }   
        else
        {
            Console.WriteLine("Invalid Time");
        }

    }
}