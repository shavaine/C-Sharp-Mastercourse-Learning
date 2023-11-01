﻿using System;
using System.Collections.Generic;

namespace Generics
{
    internal class Program
    {
        static void Main(string[] args)
        {
/*            string result = FizzBuzz("tests");

            Console.WriteLine($"Tests: {result}");

            result = FizzBuzz(123);

            Console.WriteLine($"123: {result}");

            result = FizzBuzz(true);

            Console.WriteLine($"true: {result}");

            result = FizzBuzz(new PersonModel { FirstName = "Tim", LastName = "Corey" });

            Console.WriteLine($"PersonModel: {result}");*/

            GenericHelper<PersonModel> peopleHelper = new GenericHelper<PersonModel>();
            peopleHelper.CheckItemAndAdd(new PersonModel { FirstName = "Tim", HasError = true });

            foreach (var item in peopleHelper.RejectedItems)
            {
                Console.WriteLine($"{item.FirstName} {item.LastName} was rejected.");
            };

            GenericHelperPractice(true);
            GenericHelperPractice(new PersonModel { FirstName = "Shavaine", LastName = "Brown"});
            GenericHelperPractice(123456);
        }

        // 3 - Fizz, 5 - Buzz, 3 & 5 - FizzBuzz
        private static string FizzBuzz<T>(T item)
        {
            int itemLength = item.ToString().Length;
            string output = "";

            if (itemLength % 3 == 0)
            {
                output += "Fizz";
            }

            if (itemLength % 5 == 0)
            {
                output += "Buzz";
            }

            return output;

        }

        public class GenericHelper<T> where T: IErrorCheck
        {
            public List<T> Items { get; set; } = new List<T>();
            public List<T> RejectedItems { get; set; } = new List<T>();

            public void CheckItemAndAdd(T item)
            {
                if (item.HasError == false)
                {
                    Items.Add(item);
                }
                else
                {
                    RejectedItems.Add(item);
                }
            }
        }

        public interface IErrorCheck
        {
            bool HasError { get; set; }
        }

        public class CarModel : IErrorCheck
        {
            public string Manufacturer { get; set; }
            public int YearManufactured { get; set; }
            public bool HasError { get; set; }
        }

        public class PersonModel: IErrorCheck
        {
            public string FirstName { get; set; }
            public string LastName { get; set; }
            public bool HasError { get; set; }

            public override string ToString()
            {
                return $"{FirstName}{LastName}";
            }
        }

        public static void GenericHelperPractice<T>(T item)
        {
            Console.WriteLine(item.ToString());
        }
        
    }


}
