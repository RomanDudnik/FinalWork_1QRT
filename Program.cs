void FnlArrayElements (string [] mainArray, string [] newArray)
{   
    int count = 0;
    for (int i = 0; i < mainArray.Length; i++)
        if (mainArray[i].Length <=3)
        {
            newArray[count] = mainArray[i];
            count++;
        }
}

void ShowArray (string [] array)
{
    for (int i = 0; i < array.Length; i++)
        Console.Write (array[i] + " ");
    Console.WriteLine ();
}


string [] mainArray = new string [6] { "Hello", "SPb", "2", "World", "etc", "Bye" };
string [] newArray = new string [mainArray.Length];

FnlArrayElements (mainArray, newArray);
ShowArray (newArray);

