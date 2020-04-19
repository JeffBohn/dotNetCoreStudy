using System;
using static System.Console;
using System.Text;

namespace FizzBuzz
{
    class Program
    {
        static string expected =
        "1,2,Fizz,4,Buzz,Fizz,7,8,Fizz,Buzz,11,Fizz,13,14,FizzBuzz,16,17,Fizz,19,Buzz,Fizz,22,23,Fizz,Buzz,26,Fizz,28,29,FizzBuzz,";
        static void Main(string[] args)
        {
            var sb = new StringBuilder();
            for (int i = 1; i<31; i++)
            {
                sb.Append(RecallPracticeExpressionBodiedFunction(i) + ",");
            }
            string actual = sb.ToString();
            WriteLine("Actual");
            WriteLine($"{actual}");
            WriteLine("Expected");
            WriteLine($"{expected}");
            if (actual == expected)
            {
                WriteLine("PASS");
            }
            else
            {
                WriteLine("FAIL");
            }
        }

        static string FizzBuzzResponse(int i)
        {
            string result;
            int type = 0b00;
            if (i%3==0) 
            {
                type |= 0b01; // Fizz
            }
            if (i%5==0)
            {
                type |= 0b10; // Buzz
            }
            switch (type)
            {
            case 0b01:
                result = "Fizz";
                break;
            case 0b10:
                result = "Buzz";
                break;
            case 0b11:
                result = "FizzBuzz";
                break;
            default:
                result = i.ToString();
                break;                
            }
            return result;
        }

        static string FizzBuzzResponse2(int i)
        {
            string result;
            result = i switch
            {
                int fb when fb%3==0&&fb%5==0 => "FizzBuzz",
                int f when f%3==0            => "Fizz",
                int b when b%5==0            => "Buzz",
                _                            => i.ToString(),
            };
            return result;
        }        

        static string FizzBuzzResponse3(int i) =>
        i switch
        {
            int fb when fb%3==0&&fb%5==0 => "FizzBuzz",
            int f when f%3==0            => "Fizz",
            int b when b%5==0            => "Buzz",
            _                            => i.ToString(),
        };

        static string FizzBuzzResponse4(int i) =>
        i switch
        {
            int fb when fb%3==0&&fb%5==0 => "FizzBuzz",
            int f when f%3==0            => "Fizz",
            int b when b%5==0            => "Buzz",
            _                            => i.ToString(),
        };


        static string RecallPracticeSwitchExpression(int i)
        {
            string result = i switch
            {
                int fb when fb%3==0&&fb%5==0 => "FizzBuzz",
                int f when f%3==0            => "Fizz",
                int b when b%5==0            => "Buzz",
                _                            => i.ToString(),
            };
            return result;
        }

        static string RecallPracticeExpressionBodiedFunction(int i) =>
            i switch 
            {
                int fb when fb%3==0&&fb%5==0 => "FizzBuzz",
                int f when f%3==0            => "Fizz",
                int b when b%5==0            => "Buzz",
                _                            => i.ToString(),
            };
        



    }
}
