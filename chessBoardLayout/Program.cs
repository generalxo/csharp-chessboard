namespace chessBoardLayout
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

            ChessBoard();
        }

        static void ChessBoard()
        {
            Console.Clear();

            int boardSize;
            string respons;

            //List<Position> boardPositions = new List<Position>();
            List<List<string>> positionId = new List<List<string>>();

            Console.WriteLine("Enter Size of board");
            Int32.TryParse(Console.ReadLine(), out boardSize);

            string[,] stringArray2d = new string[boardSize, boardSize];
            for (int i = 0; i < boardSize; i++)
            {
                for (int j = 0; j < boardSize; j++)
                {
                    Console.Write(stringArray2d);
                }
            }


            Console.WriteLine();
            //for (int q = 0; q < boardSize; q++)
            //{
            //    for (int w = 0; w < boardSize; w++)
            //    {
            //        Console.Write(stringArray2d[q, w]);
            //    }
            //    Console.WriteLine("");
            //}
            //while (i < boardSize)
            //{
            //    for (int j = 0; j < boardSize; j++)
            //    {
            //        Position newBoardPosition = new Position(i, (j + 1));
            //        boardPositions.Add(newBoardPosition);

            //        //Console.Write(((i + j) % 2 == 0) ? "X" : "0");
            //    }
            //    //Console.WriteLine("");
            //    i++;
            //}

            //foreach (Position boardID in boardPositions)
            //{
            //    //Console.WriteLine("boardID.arrID: " + boardID.arrID);
            //    //Console.WriteLine(boardID.xPos + boardID.yPos);

            //    if (boardID.yPos == 5)
            //    {
            //        Console.WriteLine("");
            //    }
            //    else if ((boardID.xPos + boardID.yPos) % 2 == 0)
            //    {
            //        Console.Write("O");
            //    }
            //    else
            //    {
            //        Console.Write("X");
            //    }

            //    //Console.WriteLine("boardID.xPos: " + boardID.xPos);
            //    //Console.WriteLine("boardID.yPos: " + boardID.yPos);
            //}

            //Console.WriteLine("boardPositions[0].arrID: " + boardPositions[0].arrID);



            //List<List<int>> list = new List<List<int>>()
            //{
            //    new List<int>{ boardPositions[0].xPos, boardPositions[0].yPos },
            //    new List<int>{ boardPositions[1].xPos, boardPositions[1].yPos }
            //};

            //int[][] arr = list.Select(g => g.ToArray()).ToArray();

            //foreach (var array in arr)
            //{
            //    Console.WriteLine(String.Join(", ", array));
            //}

            //Console.WriteLine("Enter A valid position like A2");
            //respons = Console.ReadLine();

            //foreach (Position boardID in boardPositions)
            //{
            //    if (respons == boardID.arrID)
            //    {
            //        Console.WriteLine("test");
            //    }
            //}

        }


    }

    class Position
    {
        public int xPos;
        public int yPos;
        public string arrID;

        public char[] letters = "ABCDEFGHIJKLMNOPQRSTUVWXYZ".ToCharArray();

        public Position(int xPos, int yPos)
        {
            this.xPos = xPos;
            this.yPos = yPos;
            arrID = letters[xPos].ToString() + yPos;

        }

    }

}