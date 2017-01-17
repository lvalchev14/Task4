using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_04
{
    class Program
    {
        static void Main(string[] args)
        {
            int Groups = int.Parse(Console.ReadLine());
            double totalPeople = 0;
            double automobile = 0;
            double microbus = 0;
            double minibus = 0;
            double bus = 0;
            double train = 0;
            for (int currGroup = 0; currGroup < Groups; currGroup++)
            {
                int eachGroupMembers = int.Parse(Console.ReadLine());
                totalPeople += eachGroupMembers;
                if (eachGroupMembers <= 5)
                {
                    automobile += eachGroupMembers;
                }
                else if (eachGroupMembers >= 6 && eachGroupMembers <= 12)
                {
                     microbus += eachGroupMembers;
                }
                else if (eachGroupMembers >= 13 && eachGroupMembers <= 25)
                {
                     minibus += eachGroupMembers;
                }
                else if (eachGroupMembers >= 26 && eachGroupMembers <= 40)
                {
                    bus += eachGroupMembers ;
                }
                else
                {
                   train+= eachGroupMembers;
                }
            }
            double P1 = (automobile / totalPeople) * 100;
            double P2 = (microbus / totalPeople) * 100;
            double P3 = (minibus / totalPeople) * 100;
            double P4 = (bus / totalPeople) * 100;
            double P5 = (train / totalPeople) * 100;
            Console.WriteLine("{0:F2}%", P1);
            Console.WriteLine("{0:F2}%", P2);
            Console.WriteLine("{0:F2}%", P3);
            Console.WriteLine("{0:F2}%", P4);
            Console.WriteLine("{0:F2}%", P5);
        }
    }
}
