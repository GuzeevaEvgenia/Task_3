using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tools
{
    public class Student :IComparable
    {
        public string FIO { get; set; }
        public DateTime Year { get; set; }
        public List<double> MedB { get; set; }
        public byte Kurs { get; set; }
        public byte Group { get; set; }
        public double GetMedB
        {
            get
            {
                double sum = 0;
                foreach (var item in MedB)
                    sum += item;
                return sum / MedB.Count;
            }
        }

        public Student(string fIO, DateTime year, List<double> medB, byte kurs, byte group)
        {
            FIO = fIO;
            Year = year;
            MedB = medB;
            Kurs = kurs;
            Group = group;
        }
        
        public static List<Student> YoungN(List<Student> list, int N)
        {
            List<Student> students = new List<Student>(list);
            students.Sort();
            students.Reverse();
            if(students.Count>N)
            students.RemoveRange(N, students.Count - N);
            return students;
        }

        public int CompareTo(object obj)
        {
            return Year.CompareTo(((Student)obj).Year);
        }
    }
}
