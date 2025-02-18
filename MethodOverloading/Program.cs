namespace MethodOverloading
{
    public class Program
    {
        public static int AddItems(int num1, int num2)
        {
            return num1 + num2;
            
        }
        public static double AddItems(double num1, double num2)
        {
            return num1 + num2;
        }
        public static string AddItems(int num1, int num2, bool word)
        {
            var addAnswer = num1 + num2;

            if (word == true && addAnswer == 1)
            {

                return $"{addAnswer} dollar";
            }
            else if (word == true && addAnswer > 1)
            {
                return $"{addAnswer} dollars" ;
            }
            else
            {
                return $"{addAnswer} dollars" ;
            }
            }
            

        static void Main(string[] args)
        {
            
            //var addAnswer = num1 + num2;

            int a = 3;
            int b = 2;
            var answerOne = AddItems(a, b);
            var answerOneAgain = AddItems(3, 2);
            Console.WriteLine($"{answerOne}");
            Console.WriteLine($"{answerOneAgain}");

            Console.WriteLine();

            var answerTwo = AddItems(.983, 2.814);
            Console.WriteLine($"{answerTwo}");

            Console.WriteLine();

            var answerThree = AddItems(8, 3, true);
            Console.WriteLine($"{answerThree}");
        }
    }
}
