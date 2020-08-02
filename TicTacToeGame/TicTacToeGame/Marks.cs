using System;
using System.Collections.Generic;
using System.Text;

namespace TicTacToeGame
{
    public class Marks
    {
        public string Place;//адрес метки
        public string type="#";//тип метки, по дефолту #, изменяется либо на х, либо на о
        public int count;
        public Marks(string Place,string type)
        {
            this.Place = Place;
            this.type = type;
            this.count = count;
        }
     
        public Marks(string Place,int count)//для работы в классе Field, т.к. изначально в переменные там вводятся только значения адреса, тип метки остается дефолтным
        {
            this.Place = Place;
            this.count = count;
        }


    }
   
}
