using System;
using System.Collections.Generic;
using System.Text;

namespace Task.Models
{
    class Employee:Person
    {
        private double _salaryOfHour;
        private double _workingHour;
        public double SalaryOfHour {
            get
            {
                return _salaryOfHour;
            }
            set
            {
                if (value >= 1)
                {
                     _salaryOfHour = value;
                }
            } 
        }
        public double WorkingHour {
            get
            {
                return _workingHour;
            }
            set
            {
                if (value > 0 || value < 160)
                {
                    _workingHour = value;
                }
            } 
        }

        public Employee (string name, string surname, int age, double salaryOfHour, double workingHour)
        {
            this.Name = name;
            this.Surname = surname;
            this.Age = age;
            this.SalaryOfHour = salaryOfHour;
            this.WorkingHour = workingHour;
        }

        public double CalculateSalary()
        {
            return SalaryOfHour * WorkingHour;
        }
    }
}
