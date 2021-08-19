using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ
{
    class Program
    {
        static void Main(string[] args)
        {
            var cities = new City[]
            {
                    new City{ Name = "Rivne", Country="Ukraine", Population = 250000, IsCapital = false },
                    new City{ Name = "Warsaw", Country="Poland", Population = 1800000, IsCapital = true },
                    new City{ Name = "Lviv", Country="Ukraine", Population = 720000, IsCapital = false },
                    new City{ Name = "Krakow", Country="Poland", Population = 780000, IsCapital = false },
                    new City{ Name = "Odessa", Country="Ukraine", Population = 1020000, IsCapital = false },
                    new City{ Name = "London", Country="Great Britain", Population = 8900000, IsCapital = true },
                    new City{ Name = "Paris", Country="France", Population = 2180000, IsCapital = true },
                    new City{ Name = "Berlin", Country="Germany", Population = 3600000, IsCapital = true },
                    new City{ Name = "Wroclaw", Country="Poland", Population = 640000, IsCapital = false },
                    new City{ Name = "Kyiv", Country="Ukraine", Population = 3000000, IsCapital = true },
                    new City{ Name = "Munich", Country="Germany", Population = 1480000, IsCapital = false },
                    new City{ Name = "Dnipro", Country="Ukraine", Population = 980000, IsCapital = false },
                    new City{ Name = "Cologne", Country="Germany", Population = 1000000, IsCapital = false }
            };

            var numbers = new[] { 2, 9, 47, 69, 20, -1, 13, -26, 37, -40, 18, 70, -31, 7, -47, -7, 1 };
            #region FirstPart
            #region Cities
            /*Використовуючи синтаксис запитів вивести на екран:
                > Із "cities"
                - інформацію про столиці (назву, країну та населення);
                - назви міст, що містять букву "і" у назві міста;
                - назви столиць разом із населенням у порядку спадання населення;
                - назви країн, що містять міста, назви яких закінчуютсья на букву "w";
                - назви міст, де назва країни закінчується на "e", а назви міст починаються на букву "a";
            
            var capitalInfo = from c in cities
                              where c.IsCapital == true
                              select new
                              {
                                  Name = c.Name,
                                  Country = c.Country,
                                  Population = c.Population
                              };
            Console.WriteLine("Information about capitals:");
            foreach (var i in capitalInfo)
            {
                Console.WriteLine($"\tCapital: {i.Name} | Country: {i.Country} | Population: {i.Population}");
            }
            //----
            var containsCityI = from c in cities
                                where c.Name.Contains('i')
                                select c.Name;
            Console.WriteLine("\nCapitals name which contains 'i':");
            foreach (var i in containsCityI)
            {
                Console.WriteLine($"\t{i}");
            }
            //----
            var capitalsPopulationDesc = from c in cities
                                         where c.IsCapital == true
                                         orderby c.Population descending
                                         select new
                                         {
                                             Name = c.Name,
                                             Population = c.Population
                                         };
            Console.WriteLine("\nCapitals - population by descending:");
            foreach (var i in capitalsPopulationDesc)
            {
                Console.WriteLine($"\t{i.Name} - {i.Population}");
            }
            //----
            var citiesEndedByW = (from c in cities
                                 where c.Name.EndsWith('w')
                                 select c.Country).Distinct();
            Console.WriteLine("\nCountries name which cities ends with 'w':");
            foreach (var i in citiesEndedByW)
            {
                Console.WriteLine($"\t{i}");
            }
            //----
            //var countriesEndedWCitiesStartsA = cities.Where(c => c.Country.EndsWith('w') && c.Name.StartsWith('A')).Select(c => c.Name);
            var countriesEndedWCitiesStartsA = from c in cities
                                               where c.Name.StartsWith('A') && c.Country.EndsWith('w')
                                               select c.Name;
            Console.WriteLine("\nCities which starts with 'A' and their countries ends with 'W':");
            foreach (var i in countriesEndedWCitiesStartsA)
            {
                Console.WriteLine($"\t{i}");
            }*/
            #endregion
            #region Numbers
            /*
             Використовуючи синтаксис запитів вивести на екран:
                > Із "numbers"
                    - всі непарні числа;
                    - додатні числа із "numbers" у порядку зростання;
                    - від'ємні числа із "numbers" у порядку спадання.
                var numbers = new[] { 2, 9, 47, 69, 20, -1, 13, -26, 37, -40, 18, 70, -31, 7, -47, -7, 1 };
             
            var oddNumbers = from n in numbers
                             where n % 2 == 1 || n % 2 == -1
                             select n;
            Console.WriteLine("\nOdd numbers:");
            foreach(var i in oddNumbers)
            {
                Console.Write($"\t{i}");
            }
            //----
            var positiveNumbersInOrder = from n in numbers
                                         where n > 0
                                         orderby n
                                         select n;
            Console.WriteLine("\nPositive numbers in order:");
            foreach (var i in positiveNumbersInOrder)
            {
                Console.WriteLine($"\t{i}");
            }
            //----
            var negativeNumbersDescOrder = from n in numbers
                                           where n < 0
                                           orderby n descending
                                           select n;
            Console.WriteLine("\nNegative numbers in descending order:");
            foreach (var i in negativeNumbersDescOrder)
            {
                Console.WriteLine($"\t{i}");
            }*/
            #endregion
            #endregion
            #region SecondPart
            /*
             * Використовуючи синтаксис методів:
                > Із "cities"
                - кількість столиць;
                - назви країн;
                - кількість міст із населенням більше  1 000 000;
                - назви міст із населенням менше  1 000 000;
                - назви країн, у яких назви міст закінчуютсья на букву "w" у назві міста;
                - кількість населення в найменш заселеній столиці;
                - назви міст, крім перших і останніх чотирьох;
                > І з "numbers"
                - мінімальне, максимальне та середнє значення;
                - чи містить масив значення "-31";
                - останнє парне значення.
            */
            #region Cities
            /*
            var capitalCount = cities.Where(c => c.IsCapital == true).Count();
            Console.WriteLine($"Number of capitals: {capitalCount}");
            //----
            var countriesNames = cities.Select(c => c.Country).Distinct();
            Console.WriteLine("\nCountries names:");
            foreach (var i in countriesNames)
            {
                Console.WriteLine($"\t{i}");
            }
            //----
            var cityPopulationMoreMillion = cities.Where(c => c.Population > 1000000).Count();
            Console.WriteLine($"\nCity numbers with population more than 1m: {cityPopulationMoreMillion}");
            //----
            var cityNamesPopulationLessMillion = cities.Where(c => c.Population < 1000000).Select(c => c.Name);
            Console.WriteLine("\nCity names with population less than 1m:");
            foreach (var i in cityNamesPopulationLessMillion)
            {
                Console.WriteLine($"\t{i}");
            }
            //----
            var cityEndsByW = cities.Where(c => c.Name.Contains('w')).Select(c => c.Country).Distinct();
            Console.WriteLine("\nCountries which cities ends by 'w':");
            foreach (var i in cityEndsByW)
            {
                Console.WriteLine($"\t{ i }");
            }
            //----
            var capitalLeastPopulation = cities.Where(c => c.IsCapital == true).Min(c => c.Population);
            Console.WriteLine($"\nThe least population capital: {capitalLeastPopulation}");
            //----
            var citiesSample = cities.Skip(4).Take(cities.Length - 8).Select(c => c.Name);
            Console.WriteLine($"\nSkip first and last 4 cities:");
            foreach(var i in citiesSample)
            {
                Console.WriteLine($"\t{i}");
            }*/
            #endregion
            #region Numbers
            //----
            var minimumValue = numbers.Min();
            var averageValue = numbers.Average();
            var maximumValue = numbers.Max();
            Console.WriteLine($"Mimimum: {minimumValue}");
            Console.WriteLine($"Average: {averageValue}");
            Console.WriteLine($"Maximum: {maximumValue}");
            //----
            var checkContainsNumber = numbers.Contains(-31);
            if(checkContainsNumber)
            {
                Console.WriteLine($"\nArray contains -31!");
            }
            else
            {
                Console.WriteLine($"\nArray doesnt't contain -31!");
            }
            //----
            var lastEvenValue = numbers.Where(n => n % 2 == 0).Last();
            Console.WriteLine($"\nLast even number: {lastEvenValue}");
            //----
            #endregion
            #endregion
        }
    }
}
