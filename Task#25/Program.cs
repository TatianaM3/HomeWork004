Console.WriteLine("Введите первое число: ");
int a = int.Parse(Console.ReadLine());
Console.WriteLine("Введите второе число: ");
int b = int.Parse(Console.ReadLine());
int c = 1;

while (b <= 0){
    Console.WriteLine("Введите натуральное число: ");
    b = int.Parse(Console.ReadLine());
}

while (b >= 1){
    c *= a;
    b = b-1;
}

Console.WriteLine("ОТВЕТ: " + c);