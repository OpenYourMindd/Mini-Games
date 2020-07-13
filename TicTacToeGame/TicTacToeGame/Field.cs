using System;
using System.Collections.Generic;
using System.Text;

namespace TicTacToeGame
{
    public class Field
    {
        public Marks a1 = new Marks("a1");//Обьявление меток с их адресами, у всех по дефолту тип #
        public Marks a2 = new Marks("a2");
        public Marks a3 = new Marks("a3");
        public Marks b1 = new Marks("b1");
        public Marks b2 = new Marks("b2");
        public Marks b3 = new Marks("b3");
        public Marks c1 = new Marks("c1");
        public Marks c2 = new Marks("c2");
        public Marks c3 = new Marks("c3");

        public Field()
        {
            this.a1 = a1; this.a2 = a2; this.a3 = a3;
            this.b1 = b1; this.b2 = b2; this.b3 = b3;
            this.c1 = c1; this.c2 = c2; this.c3 = c3;
           
        }
        public void initexample()//Вывод примера поля с адресами меток
        {
            Console.WriteLine("\n");
            Console.WriteLine("Places:");
            Console.WriteLine("****************");//Отрисовка

            Console.WriteLine("* " + a1.Place + " * "+a2.Place+" * "+a3.Place+" *");
            Console.WriteLine("****************");
            Console.WriteLine("* "+ b1.Place + " * "+ b2.Place+ " * "+ b3.Place+ " *");
            Console.WriteLine("****************");

            Console.WriteLine("* "+ c1.Place+ " * "+c2.Place+ " * "+ c3.Place+ " *");
            
            Console.WriteLine("****************");
        }
        public void initfield()//Вывод поля с типами меток, то есть #/x/o
        {
            Console.WriteLine("\n");
            Console.WriteLine("*************");//Отрисовка

            Console.WriteLine("* " + a1.type + " * " + a2.type + " * " + a3.type + " *");
            Console.WriteLine("*************");
            Console.WriteLine("* " + b1.type + " * " + b2.type + " * " + b3.type + " *");
            Console.WriteLine("*************");

            Console.WriteLine("* " + c1.type + " * " + c2.type + " * " + c3.type + " *");

            Console.WriteLine("*************");
        }
        //public int Crossmove()
        //{
        //}
        //public int Zeromove()
        //{
        //}
    }
   
}

