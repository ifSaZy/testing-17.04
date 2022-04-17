using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services
{
    public class Rasschet
    {
        public static string CalculateSum(double a, double b)
        {
            var Itog = a + b;
            if (Itog > 25) return $"Сумма больше 25, 1 корень = {a+b}";
            if (Itog < 0) return $"Сумма меньше 0, нет корней";
            return $"Всё заебись, ответ {a + b}";
        }
        public static string CalculateRaz(double a, double b)
        {
            var Itog1 = a - b;
            if (Itog1 < 25) return $"Разность меньше 25, 1 корень = {a - b}";
            if (Itog1 > 0) return $"Разность больше 0, нет корней";
            return $"Всё заебись, ответ {a - b}";
        }
    }
}
