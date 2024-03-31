using Microsoft.EntityFrameworkCore;
using System;
using week11csharp.EF.Models.Entities;

namespace week11csharp.EF
{
    public class Program
    {
        public static void Main(string[] args)
        {
            using (var dbContext = new MMABooksContext())
            {
                var customers = dbContext.Customers;

                foreach (var customer in customers)
                {
                    Console.WriteLine(customer.Name);
                }
            }
        }
    }
}
