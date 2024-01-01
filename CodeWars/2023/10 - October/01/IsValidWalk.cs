using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/* --- 6 kyu Take a Ten Minutes Walk ---
 * ------------Task:
 * You live in the city of Cartesia where all roads are laid out in a perfect grid. You arrived ten minutes too
 * early to an appointment, so you decided to take the opportunity to go for a short walk. The city provides 
 * its citizens with a Walk Generating App on their phones -- everytime you press the button it sends you an 
 * array of one-letter strings representing directions to walk (eg. ['n', 's', 'w', 'e']). You always walk only a single 
 * block for each letter (direction) and you know it takes you one minute to traverse one city block, so create
 * a function that will return true if the walk the app gives you will take you exactly ten minutes (you don't 
 * want to be early or late!) and will, of course, return you to your starting point. Return false otherwise.
 * 
 * Note: you will always receive a valid array containing a random assortment of direction letters ('n', 's', 
 * 'e', or 'w' only). It will never give you an empty array (that's not a walk, that's standing still!).
*/
namespace CodeWars._2023._10___October._01
{
    internal class Kata
    {
        //public static bool IsValidWalk(string[] walk)
        //{
        //    int xAxis = 0;
        //    int yAxis = 0;

        //    if (walk.Length == 10)
        //    {
        //        for (int i = 0; i < walk.Length; i++)
        //        {
        //            if (walk[i] == "n") xAxis++;
        //            if (walk[i] == "s") xAxis--;
        //            if (walk[i] == "e") yAxis++;
        //            if (walk[i] == "w") yAxis--;
        //        }
        //        if (xAxis == 0 && yAxis == 0) return true;
        //        else return false;
        //    }
        //    else return false;
        //}
        public static bool IsValidWalk(string[] walk)
        {
            // Проверяем, что количество шагов равно 10 (минутам)
            if (walk.Length != 10)
            {
                return false;
            }

            // Подсчитываем количество шагов по каждому направлению
            int vertical = walk.Count(c => c == "n") - walk.Count(c => c == "s");
            int horizontal = walk.Count(c => c == "n") - walk.Count(c => c == "s");

            // Проверяем, вернемся ли мы в исходную точку после 10 минут
            return vertical == 0 && horizontal == 0;
        }
    }
}