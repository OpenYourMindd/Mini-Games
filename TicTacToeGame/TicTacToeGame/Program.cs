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
            newfield.initmarks(); 
            newfield.initexample();// вывод поля с адресами меток
            Random rnd = new Random();

            for (int i=0;i<9;i=i+2) //i=i+2 потому что один ход отдаем компьютеру
             {
                newfield.initfield();
                Playermove://начало нашего хода, гото для обработки ошибки 
                Console.WriteLine("Make a move:");
                string makemark = Console.ReadLine();
                for (int c = 0; c < 9; c++)
                {
                    if (newfield.marksarray[c].Place == makemark && newfield.marksarray[c].type != "O" && newfield.marksarray[c].type != "X")
                    {
                        newfield.marksarray[c].type = "X";
                        Console.WriteLine("Computer makes a move...");
                    }

                    else if(newfield.marksarray[c].Place == makemark)
                    { Console.WriteLine("Error putting a mark on marked place!Try again.");
                        bool error = true;
                        if (error = true)
                        {
                            goto Playermove;
                        }

                    }
                }
               
            Compmove://начало хода компьютера
                int compmark = rnd.Next(0,8);
                int hashtagscounter = 0;//сделано для случая когда на поле не останется места
                for (int k=0;k<9;k++)
                {
                    for (int p = 0; p < 9; p++)
                    {
                        
                        if (newfield.marksarray[p].type == "#")
                        {
                            hashtagscounter++;
                        }
                    }

                    if (newfield.marksarray[k].count == compmark && newfield.marksarray[k].type != "X" && newfield.marksarray[k].type != "O")
                    {
                        newfield.marksarray[k].type = "O";
                    }
                    else if(newfield.marksarray[k].count == compmark && newfield.marksarray[k].type == "X"&& hashtagscounter!=0|| newfield.marksarray[k].count == compmark && newfield.marksarray[k].type == "O"&& hashtagscounter!=0)
                    {
                        bool error = true;
                        if (error = true)
                        {
                            Console.WriteLine("Error putting a mark on marked place!Computer is trying again...");
                            goto Compmove;
                        }
                    }
                }

                bool WinCheck = false;
                if (  newfield.marksarray[0].type == newfield.marksarray[4].type && newfield.marksarray[4].type == newfield.marksarray[8].type && newfield.marksarray[8].type!= "#")
                { WinCheck = true; }
                else if (newfield.marksarray[6].type == newfield.marksarray[4].type && newfield.marksarray[4].type == newfield.marksarray[2].type && newfield.marksarray[2].type != "#")
                { WinCheck = true; }
                else if (newfield.marksarray[0].type == newfield.marksarray[3].type && newfield.marksarray[3].type == newfield.marksarray[6].type && newfield.marksarray[6].type != "#")
                { WinCheck = true; }
                else if (newfield.marksarray[1].type == newfield.marksarray[4].type && newfield.marksarray[4].type == newfield.marksarray[7].type && newfield.marksarray[7].type != "#")
                { WinCheck = true; }
                else if (newfield.marksarray[2].type == newfield.marksarray[5].type && newfield.marksarray[5].type == newfield.marksarray[8].type && newfield.marksarray[8].type != "#")
                { WinCheck = true; }
               else if (newfield.marksarray[0].type == newfield.marksarray[1].type && newfield.marksarray[1].type == newfield.marksarray[2].type && newfield.marksarray[2].type != "#")
                { WinCheck = true; }
                else if (newfield.marksarray[3].type == newfield.marksarray[4].type && newfield.marksarray[4].type == newfield.marksarray[5].type && newfield.marksarray[5].type != "#")
                { WinCheck = true; }
                else if (newfield.marksarray[6].type == newfield.marksarray[7].type && newfield.marksarray[7].type == newfield.marksarray[8].type && newfield.marksarray[8].type != "#")
                { WinCheck = true; }
                if (WinCheck == true)
                {
                    Console.WriteLine("End of the game!Press any button to close");
                    Console.ReadKey();
                    System.Environment.Exit(0);
                }
                
            }

            // Проверка  всех условий выигрыша: наискось,горизонтальные и вертикальные совпадения трех меток
           
            Console.ReadKey();
        }
    }
}
