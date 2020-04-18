using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Client
{
    class Constants
    {
        /// <summary>
        /// Константа даты начала марафона
        /// </summary>
        public static DateTime startMarathonDate = new DateTime(2020, 4, 30, 14, 00, 00);


        /// <summary>
        /// Метод, возвращающий время до заданной даты от начальной даты
        /// </summary>
        /// <param name="endDate">Дата, до которой идет отсчет</param>
        /// <param name="startDate">Дата, от которой идет отсчет</param>
        /// <returns> Дату в заданном формате </returns>
        public static string GetTimer(DateTime endDate, DateTime startDate)
        {
            return string.Format("{0:dd} days {0:hh} hours and {0:mm} minutes until the race starts!", endDate - startDate);
        }
    }
}
