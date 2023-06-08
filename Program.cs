Console.WriteLine("Введите номер задания: ");
int task = Convert.ToInt32(Console.ReadLine());

switch(task){
    case 64:
        task64();
        break;
    case 66:
        task66();
        break;
    case 68:
        task68();
        break;
    default:
        break;
}

void task64(){
    Console.WriteLine("Задача 64: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.\n");
    Console.Write("Введите число: ");
    int number = Convert.ToInt32(Console.ReadLine());

    void FindingNumbersNTo1(int n){
        if(n < 1){
            return;
        }
        Console.Write($"{n} ");
        FindingNumbersNTo1(n-1);
    }

    FindingNumbersNTo1(number);
}

void task66(){
    Console.WriteLine("Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.\n");
    int summationOfNumbers(int m, int n){
        if (m > n){
            return 0;
        }
        return m + summationOfNumbers(m + 1, n);
    }
    
    Console.Write("Введите значение M: ");
    int number1 = Convert.ToInt32(Console.ReadLine());
    Console.Write("Введите значение N: ");
    int number2 = Convert.ToInt32(Console.ReadLine());
    int result;

    result = summationOfNumbers(number1, number2);
    Console.WriteLine($"Сумма чисел в промежутке от {number1} до {number2} = {result}");
    
}

void task68(){
    Console.WriteLine("Введите два не отрицательных числа m и n: ");
    int m = Convert.ToInt32(Console.ReadLine());
    int n = Convert.ToInt32(Console.ReadLine());

    int result = Ackermann(m, n);

    Console.WriteLine($"Результат функции Аккермана для m = {m} и n = {n} : {result}");

    static int Ackermann(int m, int n){
        if (m == 0){
            
            return n + 1;
        
        }else if(m > 0 && n == 0){
            
            return Ackermann(m - 1, 1);

        }else{
            return Ackermann(m-1, Ackermann(m, n -1));
        }
    }

}