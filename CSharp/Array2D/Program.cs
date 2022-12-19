using System;

namespace Array2D
{
    internal class Program
    {
        class Player
        {
            private int _x, _y;

            public void SetPos(int x, int y)
            {
                //this 키워드
                //객체 자기자신 참조 키워드
                this._x = x;
                this._y = y;
                Program.map[y, x] = 5;
                Program.DisplayMap();
                Console.WriteLine();
            }

            public void MoveDown()
            {
                //움직이면 맵의 경계를 벗어나는지 체크
                if(_y >= map.GetLength(0) - 1)
                {
                    return;
                }
                else if (map[_y + 1 , _x] == 1)
                {
                    return;
                }

                SetPos(_x, _y + 1);
            }

            public void MoveUp()
            {
                //움직이면 맵의 경계를 벗어나는지 체크
                if (_y <= map.GetLength(0) + 1)
                {
                    return;
                }
                else if (map[_y - 1, _x] == 1)
                {
                    return;
                }

                SetPos(_x, _y - 1);
            }

            public void MoveRight()
            {
                //움직이면 맵의 경계를 벗어나는지 체크
                if (_x >= map.GetLength(1) - 1)
                {
                    return;
                }
                else if (map[_y, _x + 1] == 1)
                {
                    return;
                }

                SetPos(_x + 1, _y);
            }

            public void MoveLeft()
            {
                //움직이면 맵의 경계를 벗어나는지 체크
                if (_x <= map.GetLength(1) + 1)
                {
                    return;
                }
                else if (map[_y, _x - 1] == 1)
                {
                    return;
                }

                SetPos(_x - 1, _y);
            }



        }



        //0:지나갈 수 있는 길
/*        1:지나갈 수없는 벽
          2:도착지점
          5:플레이어*/

        static int[,] map = new int[5, 5]  //2차원 배열
        {
            { 0, 1, 1, 1, 1},
            { 0, 1, 1, 1, 1},
            { 0, 0, 0, 1, 1},
            { 1, 1, 0, 1, 1},
            { 1, 1, 0, 0, 2}
        };

        static void Main(string[] args)
        {
            Player player1 = new Player();
            player1.SetPos(0, 0);

            player1.MoveDown();
            player1.MoveDown();
            player1.MoveRight();

            //Player player2 = new Player();
            //player2.SetPos(0, 1);

            //DisplayMap();
        }

        static void DisplayMap()
        {
            for (int i = 0; i < map.GetLength(0); i++)
            {
                for(int j = 0; j < map.GetLength(1); j++)
                {
                    if (map[i, j] == 0)
                    {
                        Console.Write("+");
                    }
                    else if (map[i, j] == 1)
                    {
                        Console.Write("X");
                    }
                    else if (map[i, j] == 2)
                    {
                        Console.Write("*");  
                    }
                    else if (map[i, j] == 5)
                    {
                        Console.Write("@"); 
                    }
                }

                Console.WriteLine();
            }
        }
    }
}
