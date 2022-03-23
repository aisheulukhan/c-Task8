using System;


namespace Task.Models
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.Unicode;
            string name = "";
            string surname = "";
            int age = 0;
            double salaryOfHour = 0;
            double workingHour = 0;
            double iqRank = 0;
            double languageRank = 0;
            
            int key ;
            do
            {
                Console.WriteLine("Rəqəm daxil edin");
                key = Convert.ToInt32(Console.ReadLine());
                switch (key)
                {
                    case 0:
                        Console.WriteLine("1. İşçinin maaşının hesablanması");
                        Console.WriteLine("2. Şagirdin imtahan nəticələrinin ortalamasının hesablanması");
                        Console.WriteLine("3. Son");
                        break;
                    case 1:

                        
                        Console.WriteLine("Ad daxil edin: ");
                        name = Convert.ToString(Console.ReadLine());
                        Console.WriteLine("Soyad daxil edin: ");
                        surname = Convert.ToString(Console.ReadLine());
                        do
                        {
                            Console.WriteLine("Yaş daxil edin: ");
                            age = Convert.ToInt32(Console.ReadLine());
                            if (age < 18 || age >= 64)
                            {
                                Console.WriteLine("Yaşınız işləmək üçün uyğun deyil");
                            }
                        } while (age < 18 || age >= 64);
                        do
                        {
                            Console.WriteLine("Hər saat başi qazanılan maaşı daxil edin: ");
                            salaryOfHour = Convert.ToDouble(Console.ReadLine());
                            if ( salaryOfHour < 1)
                            {
                                Console.WriteLine("Maaş 1 dən az ola bilmez");
                            }
                        } while (salaryOfHour < 1);
                        do
                        {
                            Console.WriteLine("Aylıq iş saatını daxil edin: ");
                            workingHour = Convert.ToDouble(Console.ReadLine());
                            Employee e = new Employee(name, surname, age, salaryOfHour, workingHour);
                            if (workingHour < 0 || workingHour > 160 || (salaryOfHour * workingHour) > 250)
                            {


                                Console.WriteLine($"Ayliq maas: {e.CalculateSalary()}");
                            }
                            else
                            {
                                Console.WriteLine("Yanlisdir");
                            }
                                
                            
                        } while (workingHour < 0 || workingHour > 160);
                        
                        break;
                    case 2:
                        Console.WriteLine("Ad daxil edin: ");
                        name = Convert.ToString(Console.ReadLine());
                        Console.WriteLine("Soyad daxil edin: ");
                        surname = Convert.ToString(Console.ReadLine());
                        
                        
                        do
                        {
                            Console.WriteLine("Yaş daxil edin: ");
                            age = Convert.ToInt32(Console.ReadLine());
                            if (age < 6 || age > 20)
                            {
                                Console.WriteLine("Yaşi düzgün daxil edin");
                            }

                        } while (age < 6 || age > 20);
                        do
                        {
                            Console.WriteLine("IQ imtahan balınızı daxil edin: ");
                            iqRank = Convert.ToInt32(Console.ReadLine());
                            if (iqRank < 0 || iqRank > 100)
                            {
                                Console.WriteLine("İmtahan balınızı düzgün daxil edin");
                            }
                        } while (iqRank < 0 || iqRank > 100);
                        do
                        {
                            
                            Console.WriteLine("Dil imtahan balınızı daxil edin: ");
                            languageRank = Convert.ToInt32(Console.ReadLine());
                            if (languageRank < 0 || languageRank > 100)
                            {
                                Console.WriteLine("İmtahan balınızı düzgün daxil edin");
                            }
                        } while (languageRank < 0 || languageRank > 100);
                        double result = languageRank + iqRank;
                        
                        
                        
                        if (result >= 120)
                        {
                            Console.WriteLine("İmtahandan keçdiniz");
                        }
                        else
                        {
                            Console.WriteLine("İmtahandan kəsildiniz");
                        }
                        Student s = new Student(name, surname, age, iqRank, languageRank);
                        Console.WriteLine($"İmtahan nəticəsi: {s.ExamResult()}");
                        break;
                    case 3:
                        Console.WriteLine("End");
                        break;
                    default:
                        Console.WriteLine("Yalnış daxil etdiniz");
                        break;

                }
            } while (key !=3);
        }
    }
}
