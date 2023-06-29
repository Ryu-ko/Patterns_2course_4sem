using System.Diagnostics;

namespace lab2
{
    internal class Program
    {
        static void Main( string[] args )
        {
            University bstu = new University("Белорусский государственный технологический унивеситет", "БГТУ", "г. Минск, Свердлова, 13A");

            Faculty fit = new Faculty("Информационных технологий", "ИТ", "г. Минск, Свердлова, 13А, 101-4");
            Faculty tov = new Faculty("Технологии органических веществ", "ТОВ", "г. Минск, Свердлова, 13А, 104-4");
            Faculty lh = new Faculty("Лесохозяйственный", "ЛХ", "г. Минск, Свердлова, 13А, 210-1");

            bstu.addFaculty(fit);
            bstu.addFaculty(tov);
            bstu.addFaculty(lh);

            Organization org_bstu = bstu;
            Organization org_fit = fit;
            Organization org = new Organization("Стадион БГТУ", "БГТУ", "г. Минск, ул. Свердлова 13А");

            IStaff x = new Faculty("Инженерно-экономический", "ИЭ", "г. Минск, ул. Свердлова, 13А, 402-4");

            org_bstu.PrintInfo();
            org_fit.PrintInfo();
            org.PrintInfo();
            Console.WriteLine("-------------------------------------------------------------------------------");

            Console.WriteLine(((IStaff)org).printJobVacancies());
            Console.WriteLine(((IStaff)bstu).printJobVacancies());
            Console.WriteLine("-------------------------------------------------------------------------------");
            Console.WriteLine(((IStaff)fit).printJobVacancies());
            Console.WriteLine(((IStaff)tov).printJobVacancies());
            Console.WriteLine(((IStaff)org_fit).printJobVacancies());
            Console.WriteLine(x.printJobVacancies());
        }
    }
}