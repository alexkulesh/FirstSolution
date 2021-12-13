using System;

namespace Part14Task3
{   
    
    // Разработайте приложение «7 чудес света», где каждое чудо будет представлено
    // отдельным классом. Создайте дополнительный класс, содержащий точку входа.
    // Распределите приложениепо файлам проекта и с помощью пространства имён
    // обеспечьте возможность взаимодействия классов.
    
    public class Task
    {
        private static void Main(string[] args)
        {
            double heightSum = Colosseum.Height + EifelTower.Height + GreatWall.Height + HeopsPyramid.Height
                + Parthenon.Height + PisaTower.Height + Versailes.Height;
            Console.WriteLine($"Sum of wonders heights - {(float)heightSum} meters");

            double[] heights = 
            {
                Colosseum.Height, EifelTower.Height, GreatWall.Height, HeopsPyramid.Height,
                Parthenon.Height, PisaTower.Height, Versailes.Height
            };

            double maxHeight = Colosseum.Height;
            
            for (int i = 1; i < heights.Length; i++)
            {
                if (maxHeight < heights[i])
                {
                    maxHeight = heights[i];
                }
            }
            
            Console.WriteLine($"Height of the highest world wonder - {maxHeight} meters");

            string[] countries =
            {
                Colosseum.Country, EifelTower.Country, GreatWall.Country, HeopsPyramid.Country,
                Parthenon.Country, PisaTower.Country, Versailes.Country
            };

            string country = "Italy";
            int countryCount = 0;
            
            for (int i = 0; i < countries.Length; i++)
            {
                if (country == countries[i])
                {
                    countryCount++;
                }
            }
            
            Console.WriteLine($"There are(is) {countryCount} world wonder(s) from Italy");
        }
    }
    
}