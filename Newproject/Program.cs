// // 1.	Program to add two matrix [2D Array] and put the result in a third one, then print the result.

// int[,] matrix1 =
// {
//             {1,2},
//             {3,4}
// };

// int[,] matrix2 =
// {
//             {5,6},
//             {7,8}
// };

// int[,] result = new int[2, 2];

// for (int i = 0; i < matrix1.GetLength(0); i++)
// {
//     for (int j = 0; j < matrix2.GetLength(1); j++)
//     {
//         result[i, j] = matrix1[i, j] + matrix2[i, j];
//     }
// }

// Console.WriteLine("Result Matrix:");

// for (int i = 0; i < result.GetLength(0); i++)
// {
//     for (int j = 0; j < result.GetLength(1); j++)
//     {
//         Console.Write(result[i, j] + "\t");
//     }
//     Console.WriteLine();
// }
// System.Console.WriteLine("=========================================");
// // 2.	Program to find Sum & Average of 2D Array.
int[,] numbers =
       {
            {10,20,30},
            {40,50,60}
        };

int sum = 0;
int count = numbers.Length;

foreach (var item in numbers)
{
    sum += item;
}

double average = (double)sum / count;

Console.WriteLine($"Sum = {sum}");
Console.WriteLine($"Average = {average}");

// Console.WriteLine("--------------------------------------");
// // 3.	Program to Find the Frequency of Characters in a String
// Console.Write("Enter a string: ");
// string text = Console.ReadLine() ?? string.Empty;

// Dictionary<char, int> frequency = new Dictionary<char, int>();
// foreach (char c in text)
// {
//     if (frequency.ContainsKey(c))
//         frequency[c]++;
//     else]
//         frequency[c] = 1;
// }

// foreach (var item in frequency)
// {
//     Console.WriteLine($"{item.Key} : {item.Value}");
// }
// Console.Write("Enter a string: ");
// string text = Console.ReadLine();

// char[] chars = new char[text.Length];
// int[] frequency = new int[text.Length];

// int size = 0;

// foreach (char c in text)
// {
//     bool found = false;

//     for (int i = 0; i < size; i++)
//     {
//         if (chars[i] == c)
//         {
//             frequency[i]++;
//             found = true;
//             break;
//         }
//     }

//     if (!found)
//     {
//         chars[size] = c;
//         frequency[size] = 1;
//         size++;
//     }
// }

// Console.WriteLine("\nCharacter Frequency:");

// for (int i = 0; i < size; i++)
// {
//     Console.WriteLine($"{chars[i]} : {frequency[i]}");
// }
// // 4.	Program to Remove all Characters in a String Except Alphabet
// Console.Write("Enter a string: ");
// string text = Console.ReadLine();

// char[] letters = new char[text.Length];
// int index = 0;

// foreach (char c in text)
// {
//     if (char.IsLetter(c))
//     {
//         letters[index] = c;
//         index++;
//     }
// }

// Console.Write("Result: ");

// for (int i = 0; i < index; i++)
// {
//     Console.Write(letters[i]);
// }

// // Console.WriteLine();
// // 5.	Create list of float item and sort it.
// List<float> numbers = new List<float>()
//         {
//             5.6f,
//             2.1f,
//             9.8f,
//             1.3f,
//             4.4f
//         };

// for (int i = 1; i < numbers.Count; i++)
// {
//     float key = numbers[i];
//     int j = i - 1;

//     while (j >= 0 && numbers[j] > key)
//     {
//         numbers[j + 1] = numbers[j];
//         j--;
//     }

//     numbers[j + 1] = key;
// }

// Console.WriteLine("Sorted List:");

// foreach (float item in numbers)
// {
//     Console.WriteLine(item);
// }
// // // 6.	Create dictionary of student names and their Id and fill data then print it with different formats 
// Dictionary<string, int> students = new Dictionary<string, int>();

// students.Add("Ahmed", 101);
// students.Add("Mostafa", 102);
// students.Add("khalaf", 103);
// students.Add("Mona", 104);

// foreach (KeyValuePair<string, int> student in students)
// {
//     Console.WriteLine($"Name: {student.Key}, ID: {student.Value}");
// }
// 7.	what is the effect of continue and break in loop with example
// for (int i = 1; i <= 10; i++)
// {
//     if (i == 5)
//         break;

//     Console.WriteLine(i);
// }
// for (int i = 1; i <= 10; i++)
// {
//     if (i == 5)
//         continue;

//     Console.WriteLine(i);
// }
// // 8.	Try Stack and Queue on any datatype other than Int.
// 9.	Try to implement --jagged array
// int[][] jagged = new int[3][];

// jagged[0] = new int[] { 1, 2, 46 };
// jagged[1] = new int[] { 3, 4, 5, 54 };
// jagged[2] = new int[] { 6, 7, 8, 9 };

// for (int i = 0; i < jagged.Length; i++)
// {
//     for (int j = 0; j < jagged[i].Length; j++)
//     {
//         Console.Write(jagged[i][j] + " ");
//     }

//     Console.WriteLine();
// }
