/* Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

456 -> 5
782 -> 8
918 -> 1 */

Console.WriteLine("Enter number beetwen 100 and 999:");
string numberStr = Console.ReadLine() ?? "";

if(int.TryParse(numberStr, out int number)){
  if(number < 100 || number > 999){
    Console.WriteLine($"invalid input");
  }else
  {
    string str = number.ToString();
    Console.WriteLine($"Hey from string! Second digit of {str} is {str[1]}");

    SecondDigitOfNumber3Lenght(number);
  }
}else{
  Console.WriteLine($"invalid input");
}

int SecondDigitOfNumber3Lenght(int number)
{
  int res = (number / 10) % 10;
  Console.WriteLine($"Hey from math! Second digit is {res}");
  return res;
}