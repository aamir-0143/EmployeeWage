﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeWageCalculation
{
    public class EmployeeWage
    {
        public void Attendance()
        {
            Random rand = new Random();
            int rem = rand.Next() % 2;
            if (rem > 0)
            {
                Console.WriteLine("Present");
            }
            else
            {
                Console.WriteLine("Absent");
            }

        }
    }
}
