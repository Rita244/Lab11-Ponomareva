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


int[] groupIds = { 101, 104, 107, 104, 110 };
bool hasDuplicates = false;

for (int i = 0; i < groupIds.Length; i++)
{
    for (int j = i + 1; j < groupIds.Length; j++)
    {
        if (groupIds[i] == groupIds[j])
        {
            Console.WriteLine($"Найдены дубликаты: {groupIds[i]} и {groupIds[j]}");
            hasDuplicates = true;
            break; 
        }
    }

    if (hasDuplicates)
    {
        break; 
    }
}

if (!hasDuplicates)
{
    Console.WriteLine("Дубликатов не найдено.");
}

