using System;

public class Answer
{
    static bool IsPalindrome(int number)
    {
      // Введите свое решение ниже
      int FifthDigit = number%10;
      int SecondDigit = number/10%10;
      int FourthDigit = number/1000%10;
      int FirstDigit = number /10000%10;
      if (number>=10000 && number < 100000)
      { 
          if (FifthDigit==FirstDigit&& FourthDigit==SecondDigit)
        {
            return true;
        }
        else
        {
            return false;
        }
      }
      else 
      {
        Console.WriteLine ("Число не пятизначное");
        return false;
      };
    }
  
  // Не удаляйте и не меняйте метод Main! 
      static public void Main(string[] args) {
        int number;

        if (args.Length >= 1) {
            number = int.Parse(args[0]);
        } else {
           // Здесь вы можете поменять значения для отправки кода на Выполнение
            number = 131;
        }

        // Не удаляйте строки ниже
        bool result = IsPalindrome(number);
        System.Console.WriteLine($"{result}");
    }
}