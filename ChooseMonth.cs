using System;

namespace c__sources
{
    class ChooseMonth
    {
        static void Main(string[] args)
        {
            int response = 0;
            do
            {
                Console.Clear();
                Console.Write("Insert month value: ");
                int month = Convert.ToInt32(Console.ReadLine());
                PrintMonth(month);
                Console.Write("The user would do another operation? 1 = yes, 0 = no ");
                response = Convert.ToInt32(Console.ReadLine());
                if (response == 0 || response != 1){
                    break;
                }
            }
            while(response == 1);
        }

        static void PrintMonth(int value)
        {
            switch (value)
            {
                case 1:
                    Console.WriteLine("January");
                    break;
                case 2:
                    Console.WriteLine("February");
                    break;
                case 3:
                    Console.WriteLine("March");
                    break;
                case 4:
                    Console.WriteLine("April");
                    break;
                case 5:
                    Console.WriteLine("May");
                    break;
                case 6:
                    Console.WriteLine("June");
                    break;
                case 7:
                    Console.WriteLine("July");
                    break;
                case 8:
                    Console.WriteLine("August");
                    break;
                case 9:
                    Console.WriteLine("September");
                    break;
                case 10:
                    Console.WriteLine("October");
                    break;
                case 11:
                    Console.WriteLine("November");
                    break;
                case 12:
                    Console.WriteLine("December");
                    break;
                default:
                    break;
            }
        }
    }
}
