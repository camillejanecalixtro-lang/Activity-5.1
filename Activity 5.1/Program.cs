class Program
{
    private static void printItems(Stack<int> items)
    {
        foreach (var item in items)
        {
            Console.Write(item + " ");
        }
        Console.WriteLine();
    }

    static void Main()
    {
        Stack<int> score = new Stack<int>();
        int code;

        Console.WriteLine("Welcome to my STACK PROGRAM");

        do
        {
            Console.WriteLine("\nChoose what you want to do?");
            Console.WriteLine("1 - PUSH");
            Console.WriteLine("2 - POP");
            Console.WriteLine("3 - SEARCH");
            Console.WriteLine("4 - PEEK");
            Console.WriteLine("5 - DISPLAY");
            Console.WriteLine("6 - COUNT");
            Console.WriteLine("7 - EXIT");
            Console.Write("Enter code: ");

            code = Convert.ToInt32(Console.ReadLine());

            switch (code)
            {
                case 1:
                    Console.Write("\nEnter new data to push: ");
                    int data = Convert.ToInt32(Console.ReadLine());

                    score.Push(data);
                    Console.WriteLine("New data has been added!");
                    break;

                case 2:
                    Console.Write("\nEnter how many data you want to pop: ");
                    int pop = Convert.ToInt32(Console.ReadLine());

                    if (pop > score.Count)
                    {
                        Console.WriteLine("Operation not accepted.");
                    }
                    else
                    {
                        for (int i = 0; i < pop; i++)
                        {
                            score.Pop();
                        }

                        Console.WriteLine("Data has been removed!");
                    }
                    break;

                case 3:
                    Console.Write("Enter score to be search: ");
                    int ser = Convert.ToInt32(Console.ReadLine());

                    if (score.Contains(ser))
                        Console.WriteLine("The score is found!");
                    else
                        Console.WriteLine("The score not found!");
                    break;

                case 4:
                    if (score.Count > 0)
                        Console.WriteLine("Top data is: " + score.Peek());
                    else
                        Console.WriteLine("Stack is empty.");
                    break;

                case 5:
                    Console.WriteLine("All data in the stack:");
                    printItems(score);
                    break;

                case 6:
                    Console.WriteLine("Number of data in the stack: " + score.Count);
                    break;

                case 7:
                    Console.WriteLine("Program Ended.");
                    break;

                default:
                    Console.WriteLine("Invalid code.");
                    break;
            }

        } while (code != 7);
    }
}

