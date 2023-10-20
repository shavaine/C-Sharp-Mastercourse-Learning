using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionHandlingDemo
{
    public class ErrorMethods
    {
        public static void BadCall()
        {
            int[] ages = new int[] { 1, 3, 5, };

            for (int i = 0; i <= ages.Length; i++)
            {
                try
                {
                    Console.WriteLine(ages[i]);
                }
                catch (Exception ex)
                {

                    Console.WriteLine("We had an error");
                    Console.WriteLine(ex.Message);
                    throw new Exception("There was an error handling our array", ex);
                }

            }
        }
    }
}
