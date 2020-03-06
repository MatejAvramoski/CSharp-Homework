using System;

namespace DataTypesAndVariables
{
    class Program
    {
        static void Main(string[] args)
        {
            //var name = "Dejan";

            //name = 998; - NOT POSSIBLE 

            //int numberInt = 123;

            //long numberLong = 203120302301230130;

            //short numberShort = 20202;

            //char charVar = 'a';

            //bool boolTrue = true;

            //string subject = "C# basic";

            //Console.WriteLine(numberInt + numberLong);

            //=====================================================

            //double doubleOne = 10.6564;
            //double doubleTwo = 7.3456;

            //int intOne = 5;
            //int intTwo = 7;

            //double resultOne = doubleOne / doubleTwo;
            //int resultTwo = intTwo / intOne;

            //Console.WriteLine(resultOne);
            //Console.WriteLine(resultTwo);

            //========================================================

            //string stringOne = "Hello there ";
            //string stringTwo = "General Kenobi";

            //string stringNumberOne = "9";
            //string stringNumberTwo = "3";

            //string hiKenobi = stringOne + stringTwo;
            //string stringNumbers = stringNumberTwo + stringNumberOne;

            //Console.WriteLine(hiKenobi);
            //Console.WriteLine(stringNumbers);

            //int moneyAvaliable = 102;
            //int costPerMessage = 5;
            //int result = moneyAvaliable / costPerMessage;;

            //Console.WriteLine(result);

            //=======================================

            //int numberOfClones = 8;
            //int shipCapacity = 5;

            //Console.WriteLine("Please enter number of clones");
            //string userInput = Console.ReadLine();

            //int numberOfShips = int.Parse(userInput);

            //int totalClones = numberOfClones * 12 * numberOfShips;

            //int result = 0;
            //if (totalClones % shipCapacity == 0){
            //result = totalClones / shipCapacity;
            //}else{
            //result = totalClones / shipCapacity + 1;
            //}

            //Console.WriteLine("You would need " + result + " ships for " + totalClones + "clones");

            //===========================================

            //Console.WriteLine("Enter a number:");
            //int numberOne = int.Parse(Console.ReadLine());

            //Console.WriteLine("Enter a second number:");
            //int numberTwo = int.Parse(Console.ReadLine());
            //int largerNumber = 0;
            //if(numberOne > numberTwo) {
            //    Console.WriteLine("Number: " + numberOne + " is larger than " + numberTwo);
            //    if(largerNumber % 2 == 0)
            //    {
            //        Console.WriteLine("Number " + numberOne + " is even");
            //    }
            //    else
            //    {
            //        Console.WriteLine("Number " + numberOne + " is odd");
            //    }
            //}
            //else if(numberTwo > numberOne)
            //{
            //    Console.WriteLine("Number: " + numberTwo + " is larger than " + numberOne);
            //    if (largerNumber % 2 == 0)
            //    {
            //        Console.WriteLine("Number " + numberTwo + " is even");
            //    }
            //    else
            //    {
            //        Console.WriteLine("Number " + numberTwo + " is odd");
            //    }
            //}else if(numberOne == numberTwo)
            //{
            //    Console.WriteLine("The numbers are equal");
            //}

            Console.WriteLine("Enter a number from 1 to 3: ");

            int enteredNumber = int.Parse(Console.ReadLine());

            switch (enteredNumber)
            {
                case 1:
                    Console.WriteLine("You got a new car!");
                    break;
                case 2:
                    Console.WriteLine("You got a new plane!");
                    break;
                case 3:
                    Console.WriteLine("You got a new bike!");
                    break;
                default:
                    Console.WriteLine("Please enter a number from 1 to 3");
                    break;
            }

            Console.ReadLine();
        }
    }
}
