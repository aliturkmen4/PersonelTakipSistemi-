using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonelTakipSistemi
{
    class Program
    {
        static void Main(string[] args)
        {
            #region bağımsızconstructoriçin
            Person person1 = new Person();
            person1.Name = "ali";
            person1.LastName = "türkmen";
            person1.Born = new DateTime(1996, 03, 17);
            person1.Pozisyon = Statu.Isci;
            person1.StartSalary = 5000M;
            person1.StartDate = new DateTime(2015, 07, 29);
            Console.WriteLine(person1.BilgiGetir());
            #endregion

            #region bağımlıconstructoriçin
            Person person2 = new Person("ali", "türkmen", 30000M, new DateTime(1996, 03, 17), Statu.Yonetici, new DateTime(2018, 03, 17));
            Console.WriteLine(person2.BilgiGetir()); 
            #endregion
            Console.ReadLine();
        }
    }
}
