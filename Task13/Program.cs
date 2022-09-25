Console.Write("Введите число:");
int num = Convert.ToInt32(Console.ReadLine());

int Digit( int num)
{
int i=0;  
if (num > 99)
{
    int ThirdDigit = num;   
    while (num > 999)
    {
        ThirdDigit = num / 10;
        num = ThirdDigit;
        i++;
    }
        int SecondDigit = ThirdDigit % 10;
        return SecondDigit;
}
//    else
//  {
  return 0;
//  }
}
int bigresult = Digit (num);
string result = bigresult > 0 ? $"Цифра {bigresult.ToString()}" :"Третьей цифры нет";
Console.WriteLine (result);
