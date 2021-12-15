using System;

namespace Delegates
{
    class Program
    {
        public delegate int Add(int num1, int num2);
        public delegate void ID(string n);
        public delegate bool IsCold(int a);
        
        static void Main(string[] args)
        {
            #region Func,Add
            //Add add = Addition;
            //Console.WriteLine(add(2,5));

            Func<int, int, int> add = Addition;
            Console.WriteLine(add(8, 7));

            Add add1 = (a, b) => Addition(5, 1);
            
            #endregion



            #region Action,ID
            //ID AccessID = Login;
            //AccessID(email);


            Action AccessEmail = Login;
            AccessEmail();

            ID id = i => Login();
            
            #endregion


            #region Predicate,IsCold

            //IsCold temprature = Weather;
            //temprature(13);

            Predicate<int> WeatherCheck = Weather;
            WeatherCheck(17);


            IsCold isCold = y => Weather();

            #endregion
            


        }
       
        public static int Addition(int x,int y)
        {
            return x + y;
        }

        public static void Login()
        {
            string email = "farhadja@code.edu.az";

            Console.WriteLine("Email: " + email);
        }

        public static bool Weather(int degree = 0)
        {

            if (degree > 15)
            {
                Console.WriteLine("False. The weather is hot");
            }
            else 
            {
                Console.WriteLine("True.The weather is cold");
            }

            return true;
            
            
        }
    }
}
