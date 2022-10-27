class Board
{
    int[,] board;
    public Boolean x_turn = true;

    public Board()
    {
        this.board = new int[3,3] {{-1, -2, -3}, {-4, -5, -6}, {-7, -8, -9}};
    }

    public int add(int position)
    {
        if (!filled(position))
        {
            switch (position)
            {
                case 1:
                    if (x_turn)
                        board[0,0] = 1;
                    else
                        board[0,0] = 0;
                    return 0;
                case 2:
                    if (x_turn)
                        board[0,1] = 1;
                    else
                        board[0,1] = 0;
                    return 0;
                case 3:
                    if (x_turn)
                        board[0,2] = 1;
                    else
                        board[0,2] = 0;
                    return 0;
                case 4:
                    if (x_turn)
                        board[1,0] = 1;
                    else
                        board[1,0] = 0;
                    return 0;
                case 5:
                    if (x_turn)
                        board[1,1] = 1;
                    else
                        board[1,1] = 0;
                    return 0;
                case 6:
                    if (x_turn)
                        board[1,2] = 1;
                    else
                        board[1,2] = 0;
                    return 0;
                case 7:
                    if (x_turn)
                        board[2,0] = 1;
                    else
                        board[2,0] = 0;
                    return 0;
                case 8:
                    if (x_turn)
                        board[2,1] = 1;
                    else
                        board[2,1] = 0;
                    return 0;
                case 9:
                    if (x_turn)
                        board[2,2] = 1;
                    else
                        board[2,2] = 0;
                    return 0;
                default:
                    return 0;
            }
        }
        else
        {
            //spot filled error
            return -1;
        }
    }

    public Boolean filled(int position)
    {
        switch (position)
        {
            case 1:
                if (board[0,0] == 0 || board[0,0] == 1)
                    return  true;
                else
                    return false;
            case 2:
                if (board[0,1] == 0 || board[0,1] == 1)
                    return  true;
                else
                    return false;
            case 3:
                if (board[0,2] == 0 || board[0,2] == 1)
                    return  true;
                else
                    return false;
            case 4:
                if (board[1,0] == 0 || board[1,0] == 1)
                    return  true;
                else
                    return false;
            case 5:
                if (board[1,1] == 0 || board[1,1] == 1)
                    return  true;
                else
                    return false;
            case 6:
                if (board[1,2] == 0 || board[1,2] == 1)
                    return  true;
                else
                    return false;
            case 7:
                if (board[2,0] == 0 || board[2,0] == 1)
                    return  true;
                else
                    return false;
            case 8:
                if (board[2,1] == 0 || board[2,1] == 1)
                    return  true;
                else
                    return false;
            case 9:
                if (board[2,2] == 0 || board[2,2] == 1)
                    return  true;
                else
                    return false;   
            default:
                return true;
        }
    }

    public Boolean winCheck()
    {
        //check cols, rows, and diags
        return winCol() || winRow() || winDia();
    }

    public Boolean winCol()
    {
        for (int c = 0; c < 3; c++)
        {
            if (board[0,c] == board[1,c] && board[0,c] == board[2,c])
            {
                return true;
            }
        }
        return false;
    }

    public Boolean winRow()
    {
        for (int r = 0; r < 3; r++)
        {
            if (board[r,0] == board[r,1] && board[r,0] == board[r,2])
            {
                return true;
            }
        }
        return false;
    }

    public Boolean winDia()
    {
        if (board[0,0] == board[1,1] && board[0,0] == board[2,2])
        {
            return true;
        }
        else if (board[0,2] == board[1,1] && board[0,2] == board[2,0])
        {
            return true;
        }
        return false;
    }

    public void toString()
    {
        Console.WriteLine();
        for (int r = 0; r < 3; r++)
        {
            Console.Write(" ");
            for (int c = 0; c < 3; c++)
            {
                //only print 0 and 1s
                if (board[r,c] > -1)
                {
                    if (board[r,c] == 0)
                    {
                        Console.Write("O ");
                    }
                    else
                    {
                        Console.Write("X ");
                    }
                }
                else
                {
                    Console.Write(board[r,c]*-1 + " ");
                }
                
                if (c < 2)
                {
                    Console.Write("| ");
                }
            }
            Console.WriteLine();
            if (r < 2)
            {
                Console.WriteLine("---+---+---");
            }
        }
        Console.WriteLine();
    }
}
