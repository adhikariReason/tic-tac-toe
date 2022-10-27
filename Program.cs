internal class Program
{
    private static void Main(string[] args)
    {
        Board b1 = new Board();
        b1.toString();
        int count = 0;

        while (!b1.winCheck())
        {
            if (b1.x_turn)
                Console.Write("X: ");
            else   
                Console.Write("O: ");
            int position = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();
            if (b1.add(position) == -1)
            {
                Console.WriteLine("Spot filled or invalid position.");
            }
            else
            {
                b1.x_turn = !b1.x_turn;
                b1.toString();
            }
            if (count == 8)
            {
                Console.WriteLine("Its a tie!");
                break;
            }
            count++;
        }

        if (count != 8)
        {
            //output winner
            if (b1.x_turn)
            {
                Console.WriteLine("Winner is O!");
            }
            else
            {
                Console.WriteLine("Winner is X!");
            }
        }
        
    }
}