
string[] arr = new string[]{
    "hello", "2", "world", ":-)" 
};

for (int i = 0; i < arr.Length; i++)
Console.Write(arr [i] + " ");

for (int i = 0; i < arr.Length; i++)
if (arr [i].Length >= 4)
arr [i] = "";

Console.WriteLine(" ");

for (int i = 0; i < arr.Length; i++)
Console.Write(arr [i] + " ");