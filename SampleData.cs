using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using testBits.Models;

namespace testBits
{
    public class SampleData
    {
        public static void Initialize (CSVContext context)
        {
            if(!context.CSVs.Any())
            {
                context.CSVs.AddRange(
                    new CSV
                    {
                        Name = "Serhii",
                        DateDay = 24,
                        DateMonth = 3,
                        DateYear = 2002,
                        Married = false,
                        Phone = "38095",
                        Salary = 100
                    },
                    new CSV
                    {
                        Name = "Tolik",
                        DateDay = 13,
                        DateMonth = 7,
                        DateYear = 2001,
                        Married = false,
                        Phone = "38099",
                        Salary = 59
                    }
                    );
                context.SaveChanges();
            }
        }
    }
}
