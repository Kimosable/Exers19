//Задача 19
//Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
//14212 -> нет
//12821 -> да
//23432 -> да

int count = IsNumber("Введите число ");

int IsNumber(string index)
{
    System.Console.WriteLine(index);
    int number;
    while(!int.TryParse(System.Console.ReadLine(), out number))
    {
        System.Console.WriteLine("Это не число");
        System.Console.WriteLine(index);
    }
return number;
}

string number1 = count.ToString();
int head = 0; int tail = number1.Length - 1;

bool isPolindrome(string str)
{
    while(head < tail)
    {
        if(number1[head] != number1[tail])
            return false;
    head++; tail--;
    }
return true;
}

string Polindrome(bool text)
{
    if(isPolindrome(number1))
        return "Это полиндром";
    return "Это не полиндром";
}

System.Console.WriteLine(Polindrome(isPolindrome(number1)));