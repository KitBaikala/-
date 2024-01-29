Console.Clear();
Console.Write("Введите 3-х значное число: ");
int n = int.Parse(Console.ReadLine()!);
while (n < 100 || n > 999){
    Console.Write("Вы ошиблись!\nВведите 3-х значное число: ");
    n = int.Parse(Console.ReadLine()!);
}
int n3 = n % 10;
int n2 = (n / 10) % 10;
// 547 : 10 = 54
// n / 10 = 54
// 54 : 10 = 5/ (ост. 4%)
int result = 1; // ограничения |2 147 483 647|
for (int i = 0; i < n3; i++) // n3 раз
    result *= n2; // result = result * n2
Console.WriteLine($"{n2}^{n3} = {result}");
