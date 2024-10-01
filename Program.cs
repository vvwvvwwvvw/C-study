using System;
using System.Collections;

namespace ConsoleApp1
{
   
    }
    class Program
    {
        enum City
        {
            Seoul,   // 0
            Daejun,  // 1
            Busan = 5,  // 5
            Jeju = 10   // 10
        }

        static void Main(string[] args)
        {
            City myCity;

            // enum 타입에 값을 대입하는 방법
            myCity = City.Seoul;

            // enum을 int로 변환(Casting)하는 방법. 
            // (int)를 앞에 지정.
            int cityValue = (int)myCity;

            if (myCity == City.Seoul) // enum 값을 비교하는 방법
            {
                Console.WriteLine("Welcome to Seoul");
            }
        }
    }
