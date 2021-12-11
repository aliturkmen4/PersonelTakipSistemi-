using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonelTakipSistemi
{

    enum Statu
    {
        Yonetici,
        Idari,
        Isci
    }
    class Person
    {
        public Person()
        {

        }

        public Person(string name, string lastname, decimal startsalary, DateTime born, Statu pozisyon, DateTime startdate)
        {
            this.Name = name;
            this.LastName = lastname;
            this.StartSalary = startsalary;
            this.Born = born;
            this.Pozisyon = pozisyon;
            this.StartDate = startdate;
        }

        public string Name { get; set; }

        public string LastName { get; set; }

        public string FullName 
        {
            get
            {
                return Name + " " + LastName;
            }
        }
        public decimal StartSalary { get; set; }

        public DateTime Born { get; set; }

        public DateTime StartDate { get; set; }

        public int WorkYear 
        {
            get 
            {
                return DateTime.Now.Year - StartDate.Year;
            }
        }

        public int Age 
        {
            get
            {
               return DateTime.Now.Year - Born.Year;
            }
        }

        public decimal Salary
        {
            get 
            {
                if (WorkYear == 0)
                {
                    return StartSalary;
                }
                else if (WorkYear > 10) 
                {
                    return StartSalary + (StartSalary * (30M / 100M));
                }
                else if (WorkYear > 5)
                {
                    return StartSalary + (StartSalary * (20M / 100M));
                }
                else
                {
                    return StartSalary + (StartSalary * (10M / 100M));
                }
            }
        }

        public string BilgiGetir()
        {
            return FullName + " " + Age + " " + Salary + " " + WorkYear;
        }

        public Statu Pozisyon { get; set; }


    }
}
