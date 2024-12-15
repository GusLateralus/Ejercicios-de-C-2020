using System;

namespace Problema_5
{
        public enum DatoCasilla { agua, barco };

        class Tablero
        {
            private DatoCasilla[,] mat;

            public Tablero()
            {
                mat = new DatoCasilla[10, 10];
            }

            public void Graficar()
            {
                for (int f = 0; f < mat.GetLength(0); f++)
                {
                    for (int c = 0; c < mat.GetLength(1); c++)
                    {
                        if (mat[f, c] == DatoCasilla.agua)
                        {
                            Console.Write("0 ");
                        }
                        if (mat[f, c] == DatoCasilla.barco)
                        {
                            Console.Write("- ");
                        }
                    }
                    Console.WriteLine();
                }
            }

            public DatoCasilla this[int fila, int columna]
            {
                set
                {
                    mat[fila, columna] = value;
                }
                get
                {
                    return mat[fila, columna];
                }
            }
        }

        class Program
        {
            public int Nrand()
        {
            var seed = Environment.TickCount;
            var random = new Random(seed);
            var value = random.Next(0, 5);
            return value;
        }
        static void Main(string[] args)
            {
        	
            int ax , ay,bx,by, cx, cy,dx,dy;
            Console.WriteLine("\tV E L K O M M E N");
            Console.Title="BATTLESHIP!";
            Console.BackgroundColor= ConsoleColor.DarkBlue;
            Console.ForegroundColor=ConsoleColor.White;
            Console.Clear();
            Tablero tablero1 = new Tablero();
            var seed = Environment.TickCount;
            var random = new Random(seed);
            ax = random.Next(0, 10);
            var seed1 = Environment.TickCount;
            var random1 = new Random(seed);
            ay = random.Next(0, 6);
            var seed2 = Environment.TickCount;
            var random2 = new Random(seed);
            bx = random.Next(0, 10);
            var seed3 = Environment.TickCount;
            var random3 = new Random(seed);
            by = random.Next(0, 7);
            var seed4 = Environment.TickCount;
            var random4 = new Random(seed);
            cx = random.Next(0, 8);
            var seed5 = Environment.TickCount;
            var random5 = new Random(seed);
            cy = random.Next(0, 10);
            var seed6 = Environment.TickCount;
            var random6 = new Random(seed);
            dx = random.Next(0, 8);
            var seed7 = Environment.TickCount;
            var random7 = new Random(seed);
            dy = random.Next(0, 10);
            tablero1[ax, ay] = DatoCasilla.barco;
                tablero1[ax, ay+1] = DatoCasilla.barco;
                tablero1[ax, ay+2] = DatoCasilla.barco;
                tablero1[ax, ay+3] = DatoCasilla.barco;
                tablero1[ax, ay+4] = DatoCasilla.barco;
                tablero1[bx, by] = DatoCasilla.barco;
                tablero1[bx, by+1] = DatoCasilla.barco;
                tablero1[bx, by+2] = DatoCasilla.barco;
                tablero1[bx, by+3] = DatoCasilla.barco;
                tablero1[cx, cy] = DatoCasilla.barco;
                tablero1[cx+1, cy] = DatoCasilla.barco;
                tablero1[cx+2, cy] = DatoCasilla.barco;
                tablero1[dx+1, dy] = DatoCasilla.barco;
                tablero1[dx+2, dy] = DatoCasilla.barco;
                tablero1.Graficar();
                Console.WriteLine();
            Console.WriteLine();
            for (int i = 0; i <= 30; i++)
            {
                int x, y,tm;
                tm = 30 - i;
                Console.WriteLine("Quedan {0} monedas",tm);
                Console.WriteLine("Ingresa un número entero para la coordenada x: ");
                x = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Ingresa un número entero para la coordenada y: ");
                y = Convert.ToInt32(Console.ReadLine());
                if (tablero1[x, y] == DatoCasilla.barco)
                {
                    Console.WriteLine("Le diste a un barco en esta casilla");
                }
                else
                {
                    if (tablero1[x, y] == DatoCasilla.agua)
                    {
                        Console.WriteLine("Agua");
                    }
                }
            }
            Console.WriteLine("GAME OVER. Deposite una moneda de $3.... Es broma ja ja ja, se puede retirar...");
                Console.ReadKey();
            }
        }
    }
