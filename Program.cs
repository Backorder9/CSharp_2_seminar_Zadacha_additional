/* Дополнительно
Дан список чисел,
- необходимо удалить все вхождения числа 20 из него
- и вывести его в обратном порядке.
*/
int len = new Random().Next(30, 50); // Размер массива задаём случайным числом от 30 до 50.
int[] avers = new int[len];
int j = 0; // Это - счётчик числа элементов, со значением [20] в массиве avers.
for (int i = 0; i < len; i++)
{
    avers[i] = new Random().Next(15, 25); // Значения элементов массива задаём случайным числом от 15 до 25.
    if (avers[i] == 20) j++;
}
Console.WriteLine($"Создан массив целых чисел avers, содержащий {len} элементов: " + String.Join(", ", avers));
Console.WriteLine($"Количество элементов [20] в массиве = {j}."); // Счётчик числа элементов [20] массива.
int numToRemove = 20;
avers = avers.Where(val => val != numToRemove).ToArray(); // Исключение из массива avers элементов [20].
Console.WriteLine("Сокращённый массив avers: " + String.Join(", ", avers));
Console.WriteLine($"Размер массива avers после исключения из него вхождений числа [{numToRemove}] стал - {avers.Length}.");
// Начинаем выводить массив avers в обратном порядке.
int n = avers.Length;
int m = n / 2;
int b = 0; // Вспомогательная переменная для промежуточного хранения элементов массива при их перестановке.
for (int i = 0; i < m; i++)
{
    b = avers[i];
    avers[i] = avers[n - 1 - i];
    avers[n - 1 - i] = b;
}
Console.WriteLine("Обращённый массив avers: " + String.Join(", ", avers));