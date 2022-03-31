using System;

namespace practice_0329_5.cs
{
    class Program
    {
        static void Main(string[] args)
        {   int j = 1;
            while(j < 5 )
            {      for(int i = 4; i>j; i--)
                {
                    Console.Write("/");
                    
                }        
                
               
                for(int i =0; i<j; i++)
                {
                    Console.Write(" *");
                }
                Console.WriteLine("");
                j++;
            }
        }
    }
}
// for와 while을 혼합하여 아래 별을 출력하기
//   *
//  * *
// * * *
//* * * *