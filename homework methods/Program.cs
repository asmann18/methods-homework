namespace homework_methods
{
    internal class Program
    {
        static void Main(string[] args)
        {
            calculator(2023556, 5, "*");
        }
        static void calculator(int num1,int num2,string operation)
        {
            int sum = 0;
            switch (operation)
            {
                case "+":
                    sum = num1 + num2;
                    break;
                case "-":
                    sum = num1 - num2;
                    break;
                case "*":
                    sum = num1 * num2;
                    break;
                case "/":
                    sum = num1 / num2;
                    break;
            }
            Console.WriteLine( sum);
        }
    }
}