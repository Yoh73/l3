using System;

namespace lab3
{
    class Program
    {
        static void Main(string[] args)
        {
            Point one = new Point(); //1
            one.SetSym('(');
            one.Draw(2,2);

            Point  two= new Point(); //2
            two.SetSym(')');
            two.Draw(3, 2);

            Point three = new Point(); //3
            three.SetSym('|');
            three.Draw(2, 3);

            Point four = new Point(); //4
            four.SetSym('|');
            four.Draw(3, 3);

            Point five = new Point(); //5
            five.SetSym('/');
            five.Draw(2, 4);

            Point six = new Point(); //6
            six.SetSym('\\');
            six.Draw(3, 4);


            Console.WriteLine();
            Console.WriteLine("Нажмите любую клавишу для выхода...");
            Console.ReadKey();
        }
    }
    class Point
    {
        private int x;
        private int y;
        private char sym;
        public void SetX(int x)
        {
            if (x >= 0)
                this.x = x;
            else
                new ArgumentNullException("Отрицательный x");
        }
        public void SetY(int y)
        {
            if (y >= 0)
                this.y = y;
            else
                new ArgumentNullException("Отрицательный y");
        }
        public void SetSym(char symbol)
        {
            sym = symbol;
        }  
        public void Draw(int x, int y)
        {
           try
            {
                Console.SetCursorPosition(x, y);
                Console.Write(sym);
            }
            catch (ArgumentOutOfRangeException outOfRange)
            {
                Console.WriteLine("Error: {0}", outOfRange.Message);
            }

        }
    }
}
