namespace Assignment2._3._2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter bill total: ");
            double billTotal = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine();

            Console.WriteLine("Enter the tip: ");
            double tipPercentage = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine();

            double tipAmount = billTotal * (tipPercentage / 100);

            double grandTotal = billTotal + tipAmount;

            Console.WriteLine();
            Console.WriteLine($"Tip amount ({tipPercentage}%): {tipAmount:C}");
            Console.WriteLine();
            Console.WriteLine($"Grand Total: {grandTotal:C}");

        }
    }
}
