using System;

namespace BMI_Cal
{
    class Program
    {
        static void Main(string[] args)
        {
            // get input from user
            Console.WriteLine("weight :");
            double weight = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Height :");
            double Hight = Convert.ToDouble(Console.ReadLine());
            //i need to convert feet into inches 
            double IncHight = Hight * 12;

            /* was testing to make sure input works
            // Console.WriteLine("your weight,{0}" , weight );
            // Console.WriteLine("you hight, {0}", Hight );*/
           //lets creat the formula for the bmi which is 730*weight/hight^2(bmi formula for usa)
            double bmi=730 * weight / (IncHight * IncHight);
                
           Console.WriteLine("your BMI is {0}" , bmi);
            if (bmi <= 18.5)
            {
                Console.WriteLine("Your Underweight ");
            }
            else if (bmi <= 25.0)
            {
                Console.WriteLine("Your Normal");
            }
            else if (bmi <= 30)
            {
                Console.WriteLine("Your Overweight");
            }
            else if(bmi > 30)
            {
                Console.WriteLine("your Obese");
            }

        }
    }
}
