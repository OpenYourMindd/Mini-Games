using System;

namespace TicTacToeGame
{
    class Program
    {
        static void Main(string[] args)
        {
            Field newfield = new Field();//Создание нового поля с метками
            Console.WriteLine("Welcome to TicTacToe! \n Press any button to play..");
            Console.ReadKey();
            newfield.initexample();// вывод поля с адресами меток
            newfield.initfield();//вывод пока-еще-пустого поля
            for(int i=0;i<9;i=i+2)//i=i+2 потому что один ход отдаем компьютеру
            {
                string Mark = Console.ReadLine();
                //Здесь должен быть алгоритм установки меток, но не понимаю одной вещи, как без горы "иф"-ов сделать привязку к переменным в Field
                //С ходом компьютера тот же вопрос
            }
            
            // Проверка  всех условий выигрыша: наискось,горизонтальные и вертикальные совпадения трех меток
            bool WinCheck = false;
            if (newfield.a1.type == newfield.b2.type && newfield.b2.type == newfield.c3.type)
            { WinCheck = true; }
            else if (newfield.c1.type == newfield.b2.type && newfield.b2.type == newfield.a3.type)
            { WinCheck = true; }
            else if (newfield.a1.type == newfield.b1.type && newfield.b1.type == newfield.c1.type)
            { WinCheck = true; }
            else if (newfield.a2.type == newfield.b2.type && newfield.b2.type == newfield.c2.type)
            { WinCheck = true; }
            else if (newfield.a3.type == newfield.b3.type && newfield.b3.type == newfield.c3.type)
            { WinCheck = true; }
            else if (newfield.a1.type == newfield.a2.type && newfield.a2.type == newfield.a3.type)
            { WinCheck = true; }
            else if (newfield.b1.type == newfield.b2.type && newfield.b2.type == newfield.b3.type)
            { WinCheck = true; }
            else if (newfield.c1.type == newfield.c2.type && newfield.c2.type == newfield.c3.type)
            { WinCheck = true; }
            if (WinCheck = true)
                Console.WriteLine("End of the game!");
            Console.ReadKey();
        }
    }
}
