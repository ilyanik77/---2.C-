// Напишите программу, которая принимает на вход цифру,
// обозначающую день недели, и проверяет, является ли этот день выходным.
Console.WriteLine("Введите число от 1 до 7: ");
int number = Convert.ToInt32(Console.ReadLine());
if (number == 6 || number == 7) {
    Console.WriteLine("День выходной!"); 
} else {
    Console.WriteLine("День рабочий!");
}