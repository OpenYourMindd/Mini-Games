using System;
using System.Collections.Generic;
using System.Text;

namespace TicTacToeGame
{
    public class Marks
    {
        public string Place;//адрес метки
        public string type="#";//тип метки, по дефолту #, изменяется либо на х, либо на о
        public Marks(string Place,string type)
        {
            this.Place = Place;
            this.type = type;
        }
        public Marks()//дефолтные значения
        {
            string Place = "NULL";
            string type = "NULL";
        }
        public Marks(string Place)//для работы в классе Field, т.к. изначально в переменные там вводятся только значения адреса, тип метки остается дефолтным
        {
            this.Place = Place;           
        }

       // public void initmark(string Place, string type) писалось изначально, пока не нужно, но оставил на всякий случай
      //  {
      //      string markplace = Place;
       //     string marktype;
       //     switch (type) {
       //         case "x":
        //            marktype = "x";
        //            break;
        //        case "o":
        //            marktype = "o";
         //           break;
            //}
             
            

        //}

    }
   
}
