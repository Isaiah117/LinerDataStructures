
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Program
{
    private const int NUMBER_OF_MEMBERS = 50;
    private const int COUNTER = 17;

    public static void Main(string[] args)
    {
        Console.Write("Enter N: ");
        int n = int.Parse(Console.ReadLine());

        Queue<int> sequenceMembers = new Queue<int>();
        sequenceMembers.Enqueue(n);

        for (int i = 1; i <= NUMBER_OF_MEMBERS; i++)
        {
            int number = sequenceMembers.Dequeue();
            Console.WriteLine("S{0} = {1}", i, number);

           
            if (i <= COUNTER)
            {
                sequenceMembers.Enqueue(number + 1);
                sequenceMembers.Enqueue((2 * number) + 1);
                sequenceMembers.Enqueue(number + 2);
            }
        }
    }
}
