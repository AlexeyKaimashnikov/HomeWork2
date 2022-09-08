public class primer
{
    public static void Main()
        {
            Console.WriteLine("enter a three-digit number:");
    while(true)
    {
        string input = Console.ReadLine();
        if(!input.Equals("exit"))
            Console.WriteLine("{0}->{1}",input, input[1]);
        else
            break;
    }
        }
}
