Console.Write("Введите число:");
int num = Convert.ToInt32(Console.ReadLine());

int Digit( int num)

{
if (num < 1000 && num > 99)
{
     int ThirdDigit = num / 10;
     int SecondDigit = ThirdDigit % 10;
     return SecondDigit;
}
  else
 {
  return 0;
 }
}
int bigresult = Digit (num);
string result = bigresult > 0 ? $"Цифра {bigresult.ToString()}" :"Введены некоррекные данные";
Console.WriteLine (result);