namespace Calculate
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int firstNumber = Convert.ToInt32(Console.ReadLine());
            int secondNumber = Convert.ToInt32(Console.ReadLine());
            int thirdNumber = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Sum: " + (firstNumber + secondNumber + thirdNumber));
            Console.WriteLine("Minus: " + (firstNumber - secondNumber - thirdNumber));
            Console.WriteLine("Multiple: " + (firstNumber * secondNumber * thirdNumber));
            Console.WriteLine("Division: " + ((firstNumber / secondNumber) / thirdNumber));
        }
    }
}