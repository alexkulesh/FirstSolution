using System;
using Part14Task4Germany;
using Part14Task4Russia;
using Part14Task4UnitedKingdom;

namespace Part14Task4
{
    // Разработать приложение, в котором функциональность позволяет сравнить
    // население трёх столиц из разных стран. Страна обозначается пространством
    // имён, а город - классом в данном пространстве.
    
    public class Comparer
    {
        private static void Main(string[] args)
        {
            CompareNumberOfInhabitants();
        }

        public static void CompareNumberOfInhabitants()
        {
            double [] citiesInhabitants =
                {Berlin.ThousandOfInhabitants, Moscow.ThousandOfInhabitants, London.ThousandOfInhabitants};
            string[] cities = {"Berlin", "Moscow", "London"};
            
            double max = citiesInhabitants[0];
            int indexMax = 0;
            double min = citiesInhabitants[0];
            int indexMin = 0;
            
            for (int i = 1; i < citiesInhabitants.Length; i++)
            {
                if (max < citiesInhabitants[i])
                {
                    max = citiesInhabitants[i];
                    indexMax = i;
                }

                if (min > citiesInhabitants[i])
                {
                    min = citiesInhabitants[i];
                    indexMin = i;
                }
            }
            
            Console.WriteLine($"{cities[indexMax]} is the most populated capital city");
            Console.WriteLine($"{cities[indexMin]} is at least populated capital city");
        }
    }
}