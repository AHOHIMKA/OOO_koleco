using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOO_koleco.classes
{
    public class DBHelper
    {
        //Объект связи с базой данных - Объявление 
        public static Model.OOO_KolecoEntities DB { get; set; }
        
        //Пользователь вошедший в систему
        public static Model.Users User { get; set; }
    }
}
