internal class Program
{
    private static void Main(string[] args)
    {
        //Arrays
        Console.WriteLine("Enter size of Array");
        var arraySize = Convert.ToInt32(Console.ReadLine());
        var arr = new int[arraySize];

        Console.WriteLine("Enter Array Elements");
        for (var i = 0; i < arraySize; i++)
        {
            arr[i] = Convert.ToInt32(Console.ReadLine());
        }



        //Array Methods

        Array.Sort(arr);
        Array.Reverse(arr);
        Array.Clear(arr, 2, 2);
        var secondArray = new int[3] { 1, 4, 7 };
        Array.Copy(secondArray, arr, 3);
        var a = Array.IndexOf(arr, 4);
        foreach (var ele in arr)
        {
            Console.WriteLine(ele);
        }

        //RectangularArray
        var matrix = new int[3, 2] { { 1, 2 }, { 2, 4 }, { 5, 6 } };
        Console.WriteLine(matrix[2, 1]);

        //List

        var newList = new List<int>() { 1, 2, 3 };
        newList.Add(6);
        newList.AddRange(new int[2] { 1,2});

        Console.WriteLine("First IndexOf of 1:" + newList.IndexOf(1));
        Console.WriteLine("Last IndexOf of 1:" + newList.LastIndexOf(1));
        Console.WriteLine("List Count" + newList.Count);

        for(var i = 0; i < newList.Count; i++)
        {
            if (newList[i] == 1)
                newList.Remove(newList[i]);
        }

        newList.Clear();




    }
}