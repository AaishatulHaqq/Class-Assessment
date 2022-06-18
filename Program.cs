using System;

namespace AlphaApp
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Console.WriteLine("-------------Question 1----------------");
         Console.WriteLine("Enter First Word");
             string input1 = Console.ReadLine();
             int result1 = input1.Length;
             Console.WriteLine($"The length of {input1} is :  {result1}");
             Console.WriteLine("Enter Second Word");
             string input2 = Console.ReadLine();
             int result2 = input2.Length;
             Console.WriteLine($"The length of {input2} is : {result2}");
             int result3 = result1 + result2;
             Console.WriteLine($"The addition of {result1} and {result2} is : {result3}");
             var result4 = result3 > 20 ? "The sum is greater than 20" : "The sum is less than 20";
             Console.WriteLine(result4);
             var result5 = result3 > 20 ? result3 * 3 : result3 + 20;
             Console.WriteLine(result5);


             Console.WriteLine("-------------Question 2----------");
            decimal costPrice = 200.876m;
             decimal sellingPrice = 255.426m;
             decimal profit = sellingPrice - costPrice;
             Console.WriteLine($"Profit is = {profit}");
             Console.WriteLine("The decimal value before converting to 2 D.P : {0}", profit );
             decimal decimalValueTo2Dp = decimal.Round(profit, 2);
             Console.WriteLine($"The decimal value after converting to 2 D.P : ${decimalValueTo2Dp}");

             
            Console.WriteLine("-------------------Question 3------------------");
            strring word = Console.ReadLine();
            string anyWord = "\"Pneumonoultramicroscopicsilicovolcanoconiosis is the longest word in the dictionary\"";
             Console.WriteLine($"The index of the third character in {anyWord} is : {anyWord.IndexOf("n")}");
             int lengthOfWord = anyWord.Length;
             Console.WriteLine($"The length of {anyWord} is : {lengthOfWord}");
             int result6 = lengthOfWord + anyWord.IndexOf("n");
             Console.WriteLine($"The sum of {lengthOfWord} and {anyWord.IndexOf("n")} is : {result6}");
             char result7 = (char)result6;
             Console.WriteLine("{0} converts to '{1}'", result6, result7);


             Console.WriteLine("-----------Question 4-------------------");
            Console.WriteLine("Enter First Number");
             int firstNumber = Convert.ToInt32(Console.ReadLine());
             Console.WriteLine("Enter Second Number");
             int secondNumber = Convert.ToInt32(Console.ReadLine());
             int answer1 = Math.Max(firstNumber, secondNumber);
             Console.WriteLine("Number {0} is greater", answer1);*/

 
             /*Console.WriteLine("---------------------Question 5--------------------");
             int sum1 = 0;
             int i = 0;
             while(i <= 4)
             {
                Console.WriteLine("Enter Number");
                string input = Console.ReadLine();
                int x;
                bool isInteger = int.TryParse(input, out x);

                if (isInteger)
                {
                    
                    Console.WriteLine(isInteger);

                }
                else
                {
                    i--;
                    Console.WriteLine("Invalid Input!\nEnter Another Number!");
                    int anotherInput = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine(anotherInput); 
                }

                sum1 += x;
                i++;

             }
             Console.WriteLine($"The sum of the numbers is : {sum1}");*/


             Console.WriteLine("---------------------Question 6--------------");
             Const int value = 5;
            Console.WriteLine("Enter First Number");
           double num1 = Convert.ToDouble(Console.ReadLine());
           Console.WriteLine("Enter Second Number");
           double num2 = Convert.ToDouble(Console.ReadLine());
           double sum2 = num1 + num2 - value;
           Console.WriteLine("Input Answer");
           double answer2 = Convert.ToDouble(Console.ReadLine());
           if (answer2 == sum2 )
           {
            Console.WriteLine("Correct answer!");
           }
           else 
           {
            Console.WriteLine($"Wrong answer! The correct answer is : {sum2}");
           }

           

          /*Console.WriteLine("--------------------Question 7---------------");
        
             Console.WriteLine("Please enter a number between 0 and 9:");
        string a = Console.ReadLine();
 
        switch (a)
        {
            case "0": Console.WriteLine("zero"); break;
            case "1": Console.WriteLine("one"); break;
            case "2": Console.WriteLine("two"); break;
            case "3": Console.WriteLine("three"); break;
            case "4": Console.WriteLine("four"); break;
            case "5": Console.WriteLine("five"); break;
            case "6": Console.WriteLine("six"); break;
            case "7": Console.WriteLine("seven"); break;
            case "8": Console.WriteLine("eight"); break;
            case "9": Console.WriteLine("nine"); break;
            default: Console.WriteLine("This is not a digit between 0 and 9"); break;
        }*/
             
        }
    }
}
