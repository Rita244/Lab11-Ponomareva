// int[] recordBooks = { 1042, 1058, 1071, 1093, 1105 };
// int target = 9870;
// bool found = false;

// foreach (int number in recordBooks)
// {
//    if (number == target)
//    {
//       found = true;
//       break;
//    }
// }
// Console.WriteLine(found ? "Студент найден" : "Студент не найден");



// int[] pointsPerLab = { 8, -1, 10, 9, -1, 7 };
// int sum = 0;
// int completedCount = 0;

// foreach (int points in pointsPerLab)
// {
//    if (points < 0)
//    {
//       continue;
//    }

//    sum += points;
//    completedCount++;
// }

// Console.WriteLine($"Сумма баллов за сданные работы: {sum}");
// Console.WriteLine($"Количество сданных работ: {completedCount}");


// using System;

// class Program
// {
//     static void Main()
//     {
//         int[] groupIds = { 101, 104, 107, 104, 110 };

//         for (int i = 0; i < groupIds.Length; i++)
//         {
//             for (int j = i + 1; j < groupIds.Length; j++)
//             {
//                 if (groupIds[i] == groupIds[j])
//                 {
//                     Console.WriteLine($"Найдены дубликаты: {groupIds[i]} и {groupIds[j]}");
//                     return; // сразу завершаем метод при первой найденной паре
//                 }
//             }
//         }

//         Console.WriteLine("Дубликатов не найдено.");
//     }
// }



// ##Самостоятельные задания 
// ##Задача Б

// public class PrimeCheck {
//     public static void main(String[] args) {
//         int n = 29; 

//         if (n <= 1) {
//             System.out.println(n + " — не простое число.");
//             return;
//         }

//         boolean isPrime = true; 

//         for (int d = 2; d * d <= n; d++) {
//             if (n % d == 0) {
//                 isPrime = false; 
//                 break;            
//             }
//         }

//         if (isPrime) {
//             System.out.println(n + " — простое число.");
//         } else {
//             System.out.println(n + " — составное число.");
//         }
//     }
// }

// ##Задача Г

// public class DuplicateCheck {
//     public static void main(String[] args) {
//         int[] arr = {3, 5, 7, 2, 5, 9}; 

//         boolean hasDuplicate = false;  

//         for (int i = 0; i < arr.length; i++) {
//             for (int j = i + 1; j < arr.length; j++) {
//                 if (arr[i] == arr[j]) {
//                     hasDuplicate = true;  
//                     break;                
//                 }
//             }
//             if (hasDuplicate) {
//                 break;
//             }
//         }

//         if (hasDuplicate) {
//             System.out.println("В массиве есть повторяющиеся элементы.");
//         } else {
//             System.out.println("Повторяющихся элементов нет.");
//         }
//     }
// }


// ##Индивидуальный вариант

// Console.Write("Введите свою фамилию: ");
// string surname = Console.ReadLine()!.Trim();

// if (string.IsNullOrEmpty(surname))
// {
//    Console.WriteLine("Фамилия не введена. Завершение работы.");
//    return;
// }

// Random rnd = new(surname.GetHashCode() + DateTime.Now.DayOfYear);

// var assigned = Enumerable.Range(1, 10)
//     .OrderBy(_ => rnd.Next())
//     .Take(2)
//     .OrderBy(x => x)
//     .ToList();

// Console.WriteLine($"Задачи: №{assigned[0]} и №{assigned[1]}");


// ##Вариант 3

// using System;

// class Program
// {
//    static void Main()
//    {
//       int[] array = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
//       int sum = 0;

//       foreach (int num in array)
//       {
//          if (num % 3 == 0)
//          {
//             continue;
//          }

//          sum += num;
//       }

//       Console.WriteLine("Сумма чисел, не кратных 3: " + sum);
//    }
// }


// ##Вариант 6

// using System;

// class Program
// {
//     static void Main()
//     {
//         int[] array = { 1, 2, 2, 3, 5, 7 };      

//         bool isSorted = true;

//         for (int i = 0; i < array.Length - 1; i++)
//         {
//             if (array[i] > array[i + 1])
//             {
//                 isSorted = false;   
//                 break;              
//             }
//         }

//         if (isSorted)
//             Console.WriteLine("Массив отсортирован по возрастанию.");
//         else
//             Console.WriteLine("Массив НЕ отсортирован по возрастанию.");
//     }
// }


