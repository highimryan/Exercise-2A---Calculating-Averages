using System;

namespace Exercise2A_Calculating_Averages
{
    internal class Exercise2A
    {
        // This void is for calling the AdminMenu() to make your decision on what exercise to select
        private static void AdminMenu()
        {
            Console.WriteLine("What would you like to calculate?\n");

            char innerchoice;
            Console.WriteLine("Press [1] to calculate the sum of 10 numbers.");
            Console.WriteLine("Press [2] to calculate the average of 10 test scores.");
            Console.WriteLine("Press [3] to calculate a specific number of test scores.");
            Console.WriteLine("Press [4] to calculate a non-specific number of test scores.");
            innerchoice = char.Parse(Console.ReadLine());

            Console.Write("\n");

            switch (innerchoice)
            {
                case '1':
                    Console.Write("You have chosen to calculate the sum of 10 numbers!\n");
                    Sum();
                    break;

                case '2':
                    Console.Write("You have chosen to calculate the average of 10 test scores!\n");
                    Average();
                    break;

                case '3':
                    Console.Write("You have chosen to calculate the average of a specific number of test scores!\n");
                    AVGSpecificNumbers();
                    break;

                case '4':
                    Console.Write("You have chosen to calculate the average of a non specific number of test scores!\n");
                    AVGNonSpecificNumbers();
                    break;

                default:
                    AdminMenu();
                    break;
            }
            Console.Write("\nHit Enter to perform more calculations.\n");
        }

        // This void is for calculating the average of 10 test scores
        private static void Average()
        {
            Console.Write("Read 10 test scores and calculate the average and grade:\n");
            Console.Write("----------------------------------------------");
            Console.Write("\n\n");
            Console.Write("Input the 10 test scores:\n");

            float score, sum = 0, avg = 0; int i;

            for (i = 1; i <= 10; i++)
            {
                Console.Write("Enter Score {0}:", i);
                score = float.Parse(Console.ReadLine());
                sum = sum + score;
            }

            avg = sum / (i - 1);
            Console.WriteLine("Average:" + avg);

            if (avg >= 90 && avg <= 100)
                Console.WriteLine("Grade: A");
            else if (avg >= 80 && avg <= 89)
                Console.WriteLine("Grade: B");
            else if (avg >= 70 && avg <= 79)
                Console.WriteLine("Grade: C");
            else if (avg >= 60 && avg <= 69)
                Console.WriteLine("Grade: D");
            else
                Console.WriteLine("Grade: F");
            Console.Read();
        }

        // This void is for calculating the average of a non specific amount of numbers
        private static void AVGNonSpecificNumbers()
        {
            Console.Write("Read test scores and calculate the average and grade:\n", "Type End to finish anytime.");
            Console.Write("----------------------------------------------");
            Console.Write("\n\n");

            int i;
            float n, sum = 0, avg = 0;
            string input = "end";
            while (input != "end") ;
            for (i = 1; i != 0; i++)
            {
                Console.Write("Enter Score {0}:", i);
                input = (Console.ReadLine());
                n = float.Parse(Console.ReadLine());
                sum += n;

                if (input == "end")
                {
                    avg = sum / (i - 1);
                }
            }

            avg = sum / (i - 1);
            Console.WriteLine("Average:" + avg);
            if (avg >= 90 && avg <= 100)
                Console.WriteLine("Grade: A");
            else if (avg >= 80 && avg <= 89)
                Console.WriteLine("Grade: B");
            else if (avg >= 70 && avg <= 79)
                Console.WriteLine("Grade: C");
            else if (avg >= 60 && avg <= 69)
                Console.WriteLine("Grade: D");
            else
                Console.WriteLine("Grade: F");
            Console.Read();
        }

        // This void is for calculating an avg of a specific amount of numbers
        private static void AVGSpecificNumbers()
        {
            Console.Write("Read specific number of test scores and calculate the average and grade:\n");
            Console.Write("----------------------------------------------");
            Console.Write("\n\n");
            Console.Write("Input the number of test scores:\n");
            int i, n = Convert.ToInt32(Console.ReadLine());
            float score, sum = 0, avg = 0;
            for (i = 1; i <= n; i++)
            {
                Console.Write("Enter Score {0}:", i);
                score = float.Parse(Console.ReadLine());
                sum = sum + score;
            }
            avg = sum / (i - 1);
            Console.WriteLine("Average:" + avg);
            if (avg >= 90 && avg <= 100)
                Console.WriteLine("Grade: A");
            else if (avg >= 80 && avg <= 89)
                Console.WriteLine("Grade: B");
            else if (avg >= 70 && avg <= 79)
                Console.WriteLine("Grade: C");
            else if (avg >= 60 && avg <= 69)
                Console.WriteLine("Grade: D");
            else
                Console.WriteLine("Grade: F");
            Console.Read();
        }

        private static void Main()
        {
            Console.WriteLine("Exercise 2A - Calculating Averages\n");
            for (; ; )
            {
                AdminMenu();
                Console.ReadLine();
            }
        }
        // This void is for calulating the sum of only 10 numbers
        private static void Sum()
        {
            int i, n, sum = 0;

            Console.Write("Read 10 numbers and calculate sum:\n");
            Console.Write("----------------------------------------------");
            Console.Write("\n\n");
            Console.Write("Input the 10 numbers : \n");

            for (i = 1; i <= 10; i++)
            {
                Console.Write("Number-{0} :", i);
                n = int.Parse(Console.ReadLine());

                while (n > 100.00) ;
                sum += n;
            }

            Console.WriteLine("The sum of the 10 numbers is: {0}", sum);
        }
    }
}