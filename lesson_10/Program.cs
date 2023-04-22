// Задача 64: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.

// N = 5 -> "5, 4, 3, 2, 1"
// N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"


// Console.Write("Введите число: ");
// int num = int.Parse(Console.ReadLine());

// Factorial(num);

// void Factorial(int num){
//     if(num==1){
//         Console.Write($"{num}");
//     } 
//     else
//     {
//         Console.Write($"{num}, ");
//         Factorial(num-1);
//     } 
    
// }


// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.

// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

// Console.Write("Введите 1 число: ");
// int num1 = int.Parse(Console.ReadLine());
// Console.Write("Введите 2 число: ");
// int num2 = int.Parse(Console.ReadLine());

// Console.WriteLine(SumFactorial(num1,num2));

// int SumFactorial(int num1,int num2){
//     if(num2==num1){
//         return num1;
//     } 
//     else{
//         return num1 + SumFactorial(num1+1,num2);
//     } 
    
// }


// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29

// Console.Write("Введите 1 число: ");
// int num1 = int.Parse(Console.ReadLine());
// Console.Write("Введите 2 число: ");
// int num2 = int.Parse(Console.ReadLine());

// Console.WriteLine(Akerm(num1,num2));

// int Akerm(int num1, int num2)
// {
//   if (num1 == 0){
//     return num2 + 1;
//   } 
//   else{
//     if ((num1 != 0) && (num2 == 0)){
//         return Akerm(num1 - 1, 1);
//     }  
//     else{
//         return Akerm(num1 - 1, Akerm(num1, num2 - 1));
//     }
//   }
// }
