using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<Coordinates, double> ratingMap = new Dictionary<Coordinates, double>();
            while (true)
            {
                Console.WriteLine("Enter you coordinate");

                Console.WriteLine("Enter latitude");
                var latitude = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Enter longitude");
                var longitude = Convert.ToInt32(Console.ReadLine());

                Coordinates coordinates = new Coordinates(latitude, longitude);
                
                if (ratingMap.TryGetValue(coordinates, out double numRating))
                {
                    Console.WriteLine($"Latitude = {latitude}, longitude = {longitude}, raiting this coordinat is {numRating}");
                }
                else
                {
                    Console.WriteLine("Don`t have raiting for this coordinate");
                    Console.WriteLine("Enter rating to you coordinate");
                    var raiting = Convert.ToDouble(Console.ReadLine());
                    ratingMap.Add(coordinates, raiting);
                    Console.WriteLine($"Latitude = {latitude}, longitude = {longitude}, raiting this coordinat is {raiting}");
                }
            }
        }
    }
}
