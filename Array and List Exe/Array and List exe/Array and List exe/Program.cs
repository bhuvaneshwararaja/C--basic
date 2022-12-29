using Microsoft.VisualBasic;
using static System.Runtime.InteropServices.JavaScript.JSType;
using System.ComponentModel;

internal class Program
{
    private static void Main(string[] args)
    {

        //Write a program and ask the user to enter 5 numbers.
        //If a number has been previously entered, display an error message and ask the user to re-try.
        //Once the user successfully enters 5 unique numbers, sort them and display the result on the console.

        Console.WriteLine("Enter 5 Numbers");

        var counter = 0;
        var resArr = new int[5];
        while (counter < 5)
        {
            var temp = Convert.ToInt32(Console.ReadLine());
            if (Array.Exists(resArr, ele => ele == temp))
            {
                Console.WriteLine("This Number Already Exists please Enter Another number");

            }
            else
            {
                resArr[counter] = temp;
                counter++;
            }
        }

        Array.Sort(resArr);
        foreach (var res in resArr)
        {
            Console.WriteLine(res);
        }



        //Write a program and ask the user to continuously enter a number or type "Quit" to exit.
        //The list of numbers may include duplicates. Display the unique numbers that the user has entered.

        Console.WriteLine("Start Enter Any number, Type Quit to exit");
        var numberList = new List<int>();
        while (true)
        {
            var temp = Console.ReadLine();
            if (temp.ToLower() == "quit")
                break;
            numberList.Add(Convert.ToInt32(temp));
        }

        var uniqueList = new List<int>();
        foreach (var number in numberList)
        {
            if (!uniqueList.Contains(number))
                uniqueList.Add(number);
        }
        Console.WriteLine("Unique numbers are:");
        foreach (var unique in uniqueList)
        {
            Console.WriteLine(unique);
        }



        //Write a program and ask the user to supply a list of comma separated numbers (e.g 5, 1, 9, 2, 10).
        //If the list is empty or includes less than 5 numbers, display "Invalid List" and ask the user to re-try;
        //otherwise, display the 3 smallest numbers in the list.

        Console.WriteLine("Enter the comma seperated number");
        while (true)
        {
            var temp = Console.ReadLine();
            var userInputList = temp != null && temp != "" ? temp.Split(',').Select(ele => Convert.ToInt32(ele)).ToList<int>() : new List<int>();

            if (userInputList.Count < 5)
            {
                Console.WriteLine("Invalid List, please try again");
            }
            else
            {
                userInputList.Sort();
                Console.WriteLine("Smallest 3 Number is");
                foreach (var res in userInputList.Skip(0).Take(3))
                {
                    Console.WriteLine(res);
                }
                break;
            }
        }


        //Write a program and ask the user to enter their name.
        //Use an array to reverse the name and
        //then store the result in a new string.
        //Display the reversed name on the console

        Console.WriteLine("Enter your Name");
        var userName = Console.ReadLine();
        var tempArr = new Char[userName.Length];
        for (var i = 0; i < userName.Length; i++)
        {
            tempArr[i] = userName[i];
        }
        var resString = System.String.Join("", tempArr.Reverse());
        Console.WriteLine("Reversed username : " + resString);

        //When you post a message on Facebook, depending on the number of people who like your post, Facebook displays different information.

        //If no one likes your post, it doesn't display anything.
        //If only one person likes your post, it displays: [Friend's Name] likes your post.
        //If two people like your post, it displays: [Friend 1] and[Friend 2] like your post.
        //If more than two people like your post, it displays: [Friend 1], [Friend 2] and[Number of Other People] others like your post.
        //Write a program and continuously ask the user to enter different names, until the user presses Enter(without supplying a name).
        //Depending on the number of names provided, display a message based on the above pattern.

        Console.WriteLine("Have you liked my post !!!");
        var likeList = new List<System.String>();
        while (true)
        {
            var temp = Console.ReadLine();
            if(temp != "" && temp != null)
            {
                likeList.Add(temp);
            }
            else
            {
                break;
            }
        }

        if(likeList.Count == 1)
        {
            Console.WriteLine("{0} likes your post", likeList[0]);
        }
        else if(likeList.Count == 2)
        {
            Console.WriteLine("{0} and {1} likes your post", likeList[0], likeList[1]);

        }
        else if (likeList.Count > 2)
        {
            Console.WriteLine("{0}, {1} and {2} others likes your post", likeList[0], likeList[1], likeList.Count-2);

        }
        else
        {
            Console.WriteLine("no one likes your post");
        }


    }
}