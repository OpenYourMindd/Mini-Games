using System;
using System.Collections.Generic;
using System.Text;

namespace TicTacToeGame
{
    public class Field
    {

       public Marks[] marksarray = new Marks[9];//Массив со всеми метками на поле
        
        
        
       

        public Field()
        { this.marksarray = marksarray;
            
         
        }
        public void initmarks()
        {
            marksarray[0] = new Marks("a1", 0);//Обьявление меток с их адресами и порядковым номером, у всех по дефолту тип #
            marksarray[1] = new Marks("a2",1);
            marksarray[2] = new Marks("a3",2);
            marksarray[3] = new Marks("b1",3);
            marksarray[4] = new Marks("b2", 4);
            marksarray[5] = new Marks("b3",5);
            marksarray[6] = new Marks("c1",6);
            marksarray[7] = new Marks("c2",7);
            marksarray[8] = new Marks("c3",8);

        }

        public void initexample()//Вывод примера поля с адресами меток
        {
            Console.WriteLine("\n");
            Console.WriteLine("Places:");
            Console.WriteLine("****************");//Отрисовка

            Console.WriteLine("* " +marksarray[0].Place + " * "+ marksarray[1].Place+" * "+ marksarray[2].Place+" *");
            Console.WriteLine("****************");
            Console.WriteLine("* "+ marksarray[3].Place + " * "+ marksarray[4].Place+ " * "+ marksarray[5].Place+ " *");
            Console.WriteLine("****************");

            Console.WriteLine("* "+ marksarray[6].Place+ " * "+ marksarray[7].Place+ " * "+ marksarray[8].Place+ " *");
            
            Console.WriteLine("****************");
        }
        public void initfield()//Вывод поля с типами меток, то есть #/x/o
        {
            Console.WriteLine("\n");
            Console.WriteLine("*************");//Отрисовка

            Console.WriteLine("* " + marksarray[0].type + " * " + marksarray[1].type + " * " + marksarray[2].type + " *");
            Console.WriteLine("*************");
            Console.WriteLine("* " + marksarray[3].type + " * " + marksarray[4].type + " * " + marksarray[5].type + " *");
            Console.WriteLine("*************");

            Console.WriteLine("* " + marksarray[6].type + " * " + marksarray[7].type + " * " + marksarray[8].type + " *");

            Console.WriteLine("*************");
        }
       
    }
   
}

