// Принимает на вход число и выдаёт сумму цифр в числе

int GetSum (int [] col){
int sum = 0;
int length = col.Length;
for (int i = 0; i < length; i++){
    sum = sum + col[i];
}
return sum;
}

Console.WriteLine("Введите натуральное число: ");
int n = int.Parse(Console.ReadLine());
while (n <= 0){
    Console.WriteLine("Введите натуральное число: ");
    n = int.Parse(Console.ReadLine());
}

int result = GetSum(n);
Console.WriteLine(result);