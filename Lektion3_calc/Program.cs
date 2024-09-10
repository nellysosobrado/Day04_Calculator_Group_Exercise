namespace Lektion3_calc
{
    internal class Program
    {
        static void Main(string[] args)

        {

            bool TryAgain = true;
            while (TryAgain)
            {

                Console.WriteLine("Enter a number");
                int Input = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Enter a number");
                int Input2 = Convert.ToInt32(Console.ReadLine());


                Console.WriteLine("Enter an option" +
                    "\n1.Addition" +
                    "\n2.Substraction" +
                    "\n3.Multi" +
                    "\n4.Divsio" +
                    "\n5.%");

                string Option = Console.ReadLine();

                switch (Option)
                {
                    case "1":
                        Console.WriteLine($"{Input} +{Input2} = {Input + Input2}");
                        break;
                    case "2":
                        Console.WriteLine($"{Input}-{Input2} = {Input + Input2}");
                        break;
                    case "3":
                        Console.WriteLine($"{Input} * {Input2} = {Input * Input2}");
                        break;
                    case "4":
                        Console.WriteLine($"{Input} /{Input2} = {Input / Input2}");
                        break;
                    case "5":
                        Console.WriteLine($"{Input} %{Input2} = {Input % Input2}");
                        break;

                }

                Console.WriteLine("Do you want to try again (Y/N)");
                string AnswerTry = Console.ReadLine();

                switch (AnswerTry)
                {
                    case "N":
                        TryAgain = false;
                        break;
                    case "Y":
                        TryAgain = true;
                        break;

                }


            }




            Console.ReadKey();
        }
    }
}
