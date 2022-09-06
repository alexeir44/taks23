int i, j = 0;
bool check;
string? UserNumber;
int number = 0;

check = false;
UserNumber = " ";

Console.WriteLine($"Введи число");

while (check == false)
{
    UserNumber = Console.ReadLine();
    if (int.TryParse(UserNumber, out number))
    {
        check = true;
    }
    else
    {
        Console.Write("Ошибка ввода.\n Повторите ввод:");
    }
}

i = UserNumber.Length;

for (; j<=i/2; j++)
{
    if (UserNumber[j]==UserNumber[i-j-1])
        check = check & true;
    else
        check = check & false;
}
if (check == true)
    Console.Write($"Данное число полиндром");
else
    Console.Write($"Данное число не полиндром");