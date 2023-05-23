using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    [Serializable]
    public class Student
    {    
       private string surname;
       private string group;
       private string formEducation;
       private double average;

        public string Surname
        {
            get { return surname; }
            set { surname = value; }
        }

        public string Group
        {
            get { return group; }
            set { group = value; }
        }

        public string FormEducation
        {
            get { return formEducation; }

            set
            {
                if (Average >= 98)
                {
                    formEducation = "За рахунок іменної стипендії";
                }
                else
                {
                    formEducation = value;
                }

            }
        }


        public double Average
        {
            get { return average; }
            set
            {
                if (value < 0 || value > 100)
                {
                    throw new ArgumentException("Середній бал може бути в діапазоні від 0-100");
                }
                average = value;
            }
        }

        public Student() { }

        public Student(string surname, string group, string formEducation, double average)
        {
            this.surname = surname;
            this.group = group;
            this.formEducation = formEducation;
            this.average = average;
        }

        public override string ToString()
        {
            return $"StudentList [Прізвище: {surname}, Група: {group}, Форма навчання: {formEducation}, Середній бал: {average}]";
        }

    }
    [Serializable]
    public class StudentList : IList<Student>
    {
        private List<Student> studentList = new List<Student>();

        public int Count
        {
            get { return studentList.Count; }
        }

        public bool IsReadOnly
        {
            get { return false; }
        }

        public Student this[int index]
        {
            get { return studentList[index]; }
            set { studentList[index] = value; }
        }

        public void FillStudent()
        {
            studentList.Add(new Student("Іванов", "Група А", "Платна", 98.5));
            studentList.Add(new Student("Петров", "Група Б", "Безоплатна", 80.2));
            studentList.Add(new Student("Сидоров", "Група В", "Платна", 87.8));
            studentList.Add(new Student("Коваленко", "Група А", "Безоплатна", 92.1));
            studentList.Add(new Student("Попов", "Група Б", "Безоплатна", 78.9));
            studentList.Add(new Student("Волков", "Група В", "Платна", 99.7));
            studentList.Add(new Student("Кузнєцов", "Група А", "Безоплатна", 98.4));
            studentList.Add(new Student("Морозов", "Група Б", "Платна", 85.6));
            studentList.Add(new Student("Степанов", "Група В", "Безоплатна", 88.3));
            studentList.Add(new Student("Нікітін", "Група А", "Платна", 90.7));
        }

        public List<Student> GetBy(Func<Student, bool> suitableComposition)
        {
            return studentList.Where(suitableComposition).ToList();
        }

        public void WriteToFile(IFormatter formatter, string pathToFile)
        {
            using (FileStream fileStream = new FileStream(pathToFile, FileMode.Create))
            {
                formatter.Serialize(fileStream, this);
            }
        }

        public void ReadFromFile(IFormatter formatter, string pathToFile)
        {
            using (FileStream fileStream = new FileStream(pathToFile, FileMode.Open))
            {
                foreach (Student o in formatter.Deserialize(fileStream) as StudentList)
                {
                    studentList.Add(o);
                }
            }
        }

        public int IndexOf(Student item)
        {
            return studentList.IndexOf(item);
        }

        public void Insert(int index, Student item)
        {
            studentList.Insert(index, item);
        }

        public void RemoveAt(int index)
        {
            studentList.RemoveAt(index);
        }

        public void Add(Student item)
        {
            studentList.Add(item);
        }

        public void Clear()
        {
            studentList.Clear();
        }

        public bool Contains(Student item)
        {
            return studentList.Contains(item);
        }

        public void CopyTo(Student[] array, int arrayIndex)
        {
            studentList.CopyTo(array, arrayIndex);
        }

        public bool Remove(Student item)
        {
            return studentList.Remove(item);
        }

        public IEnumerator<Student> GetEnumerator()
        {
            return studentList.GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return studentList.GetEnumerator();
        }

        public void Sort(Comparison<Student> comparator)
        {
            studentList.Sort(comparator);
        }
    }
}


