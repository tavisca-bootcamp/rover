using System;
namespace rover
{
    class Rover
    {
        public static int row, column;
        static void Main(string[] args)
        {
            string[] dim = Console.ReadLine().Split(' ');
            column = Convert.ToInt32(dim[0]);
            row = Convert.ToInt32(dim[1]);
            for (int i = 0; i < 2; ++i)
            {
                int X, Y;
                string[] pos = Console.ReadLine().Split(' ');
                X = Convert.ToInt32(pos[0]);
                Y = Convert.ToInt32(pos[1]);
                char InitialFaceDirection = char.Parse(pos[2]);
                string directions = Console.ReadLine();

                char prevDirection = InitialFaceDirection;
                for (int move = 0; move < directions.Length; ++move)
                {
                    if (directions[move] == 'M')
                    {
                        if (isValid(X, Y + 1) && prevDirection == 'N')
                            ++Y;
                        if (isValid(X + 1, Y) && prevDirection == 'E')
                            ++X;
                        if (isValid(X - 1, Y) && prevDirection == 'W')
                            --X;
                        if (isValid(X, Y - 1) && prevDirection == 'S')
                            --Y;
                    }
                    else
                    {
                        switch (directions[move])
                        {
                            case 'R':
                                if (prevDirection == 'N')
                                    prevDirection = 'E';
                                else if (prevDirection == 'E')
                                    prevDirection = 'S';
                                else if (prevDirection == 'W')
                                    prevDirection = 'N';
                                else if (prevDirection == 'S')
                                    prevDirection = 'W';
                                break;
                            case 'L':
                                if (prevDirection == 'N')
                                    prevDirection = 'W';
                                else if (prevDirection == 'E')
                                    prevDirection = 'N';
                                else if (prevDirection == 'W')
                                    prevDirection = 'S';
                                else if (prevDirection == 'S')
                                    prevDirection = 'E';
                                break;
                            default:
                                System.Console.WriteLine("Invalid option");
                                break;
                        }
                    }
                }
                System.Console.WriteLine(X + " " + Y + " " + prevDirection);
            }
        }
        public static bool isValid(int x, int y)
        {
            return (x >= 0 && x <= column && y >= 0 && y <= row);
        }
    }
}
