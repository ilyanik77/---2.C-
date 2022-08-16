// Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
Console.WriteLine("Введите число от 0 до 999: ");
int number = Convert.ToInt32(Console.ReadLine());
if (number < 100) {
    Console.WriteLine("Третьей цифры нет");
} else {
    int result = number % 10;
    Console.WriteLine(result);
}