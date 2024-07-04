using System.Numerics;

namespace ConsoleApp4
{
    internal class Program
    {
        public static int sumarray(int[] array) 
        {
            int sum = 0;
         if (array is not null) 
            {
                array = new int[] { 4, 5, 6 };
            for (int i = 0; i < array.Length; i++) 
                {
                sum += array[i];
                
                }
            } return sum;
        
        }
        public static int sumarr(ref int[] array)
        {
            int sum = 0;
            if (array is not null)
            {
                array = new int[] { 4, 5, 6 };
                for (int i = 0; i < array.Length; i++)
                {
                    sum += array[i];

                }
            }
            return sum;

        }
        public static void sumAndMulti(int a ,int b ,int c ,int d ,out int  sum ,out int subtract)

        {
            sum = a + b;
            subtract = c -d ;


        }

        public static int sd(int num)
        {
            int sum = 0;
        

            while (sum != 0) 
            {

                sum += num % 10;
                sum /= 10;
               

            }
                   return sum; 

        }

        public static bool Isprime(int num)
        { 
          
              
                if (num %2 ==0 && num >2)
                {
                  return true;  
                }
              for (int i = 2;i <=Math.Sqrt(num);i++)
              {
                if (num % i == 0)
                {
                    return false;
                    
                }
                

              }

               return true;
          
        
        
        
        }


        public static void minmax(int[] array, out int min, out int max)

        { 
         min = array[0]; max = array[0];
            foreach(int i in array)
            { 
                if(i < min) min = i; if(i > max) max = i;
                    
                        
                        
                        
            }
        
        
        
        }

        public static int factorial(int factor) 
        {
        if (factor==0)
            {  return 1; }
            int r = 1;
            for (int i = 1; i <= factor; i++)
            {

                r *= i;

            } return r;






        }
       
        public static string changechar(string s , int p ,char newchar)
        {
            char[] array = s.ToCharArray();
            array[p]=newchar;
            return new string(array);




        }


        static void Main(string[] args)
        {
            #region Q1 passing by value
            //int[] num = { 1, 2, 3, 4, 5, 6, 7, 8, 9, };
            //int r = sumarray(num);
            //Console.WriteLine(num[0]);
            //Console.WriteLine(r);



            #endregion

            #region Q2



            //int[] num = { 1, 2, 3, 4, 5, 6, 7, 8, 9, };
            //int r = sumarr(ref  num);
            //Console.WriteLine(num[0]);
            //Console.WriteLine(r);
            #endregion

            #region Q3



            //Console.WriteLine("num1") ;
            //int num1 = int.Parse(Console.ReadLine()) ;

            //Console.WriteLine("num2");
            //int num2 = int.Parse(Console.ReadLine());
            //Console.WriteLine("num3");
            //int num3 = int.Parse(Console.ReadLine());

            //Console.WriteLine("num4");
            //int num4 = int.Parse(Console.ReadLine());
            //int s, st;

            //sumAndMulti(num1,num2,num3,num4, out s,out st);

            //Console.WriteLine($"sum num1+num2 = {s}");
            //Console.WriteLine($"subtract num3 - num 4 =  {st}");

            #endregion

            #region Q4

            //Console.WriteLine("input number");
            //int num = int.Parse(Console.ReadLine());
            //int t = sd(num);
            //Console.WriteLine(t);


            #endregion

            #region Q5


            //Console.WriteLine("number");
            //int x = int.Parse(Console.ReadLine());
            //bool z= Isprime(x);
            //if (z) 
            //{
            // Console.WriteLine("is prime");
            //}
            //else 
            //{
            //    Console.WriteLine("not prime");
            //}    



            #endregion

            #region Q6

            //int[] num = { 1, 2, 3, 4, 5, 6, 7, 8, };
            //minmax(num,out int min ,out int max);
            //Console.WriteLine(min);
            //Console.WriteLine(max);




            #endregion


            #region Q7

            //int num = 5;
            //int fact = factorial(num);
            //Console.WriteLine(fact);


            #endregion

            #region Q8

            //string String = "h";
            //int p = 0;  
            //char Char = 'a';    
            //string m = changechar(String,p,Char);
            //Console.WriteLine($"old char => {String} new cahr is {m}");

            #endregion
        }
    }
}
