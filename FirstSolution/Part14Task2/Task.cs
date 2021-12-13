using System;

namespace Part14Task2
{
    // Придумать класс, описывающий студента. Предусмотреть в нем следующие
    // моменты: фамилия, имя, отчество, группа, возраст, массив оценок по
    // программированию, администрированию и дизайну. А также добавить методы
    // по работе с перечисленными данными: возможность установки/получения
    // оценки, получение среднего балла по заданному предмету, распечатка
    // данных о студенте.

    public class Task
    {
        private static void Main(string[] args)
        {
            Student student1 = new Student("Kulesh", "Alexander", "Sergeevich", 1, new[] {9, 8, 5}, new[] {7, 7, 7},
                new[] {5, 4, 7});
            Student student2 = new Student("Filipovich", "Petr", "Alexseevich", 4, new[] {8, 8, 10}, new[] {4, 5, 6},
                new[] {6, 6, 8});
            Student student3 = new Student("Mankevich", "Ekaterina", "Andreevna", 2, new[] {6, 5, 7}, new[] {7, 7, 4},
                new[] {8, 7, 6});
            student1.PrintStudentInfo();
            student2.PrintStudentInfo();
            student3.PrintStudentInfo();
            Console.WriteLine("Average grade on programming " + student1.CountAverageGrade(student1.ProgrammingGrades));
            Console.WriteLine("Average grade on administration " + student1.CountAverageGrade(student1.AdministrationGrades));
            Console.WriteLine("Average grade on design " + student1.CountAverageGrade(student1.DesingGrades));
        }
    }

    public class Student
    {
        private string secondname;
        private string firstname;
        private string middlename;
        private int group;
        private int[] programmingGrades;
        private int[] administrationGrades;
        private int[] designGrades;

        public Student(string secondname, string firstname, string middlename, int group, int[] programmingGrades,
            int[] administrationGrades, int[] designGrades)
        {
            this.secondname = secondname;
            this.firstname = firstname;
            this.middlename = middlename;
            this.group = group;
            this.programmingGrades = programmingGrades;
            this.administrationGrades = administrationGrades;
            this.designGrades = designGrades;
        }

        public void PrintStudentInfo()
        {
            Console.WriteLine($"Students info : {firstname}, {middlename}, {secondname}, {group} group");
            PrintStudentGrades();
        }
        
        public void PrintStudentGrades()
        {   
            Console.WriteLine($"{firstname} {secondname}'s grades");
            Console.WriteLine("Programming grades");
            
            for (int i = 0; i < programmingGrades.Length; i++)
            {
                Console.Write(programmingGrades[i] + " ");
            }

            Console.WriteLine("\nAdministration grades");
            
            for (int i = 0; i < administrationGrades.Length; i++)
            {
                Console.Write(administrationGrades[i] + " ");
            }

            Console.WriteLine("\nDesign grades");
            
            for (int i = 0; i < designGrades.Length; i++)
            {
                Console.Write(designGrades[i] + " ");
            }
            Console.WriteLine();
        }

        public float CountAverageGrade(int[] grades)
        {
            float sum = 0;
            
            for (int i = 0; i < grades.Length; i++)
            {
                sum += grades[i];
            }

            float averageScore = sum / grades.Length;
            return averageScore;
        }
        
        public int GetProgrammingGrade(int index)
        {
            return programmingGrades[index];
        }
        
        public void SetProgrammingGrade(int index, int grade) =>  programmingGrades[index] = grade;
            
        public int GetAdministrationGrade(int index)
        {
             return administrationGrades[index];
        }
        
        public void SetAdministrationGrade(int index,int grade) => administrationGrades[index] = grade;
        
        public int GetDesingGrade(int index) 
        {
            return designGrades[index];
        }
        
        public void SetDesignGrade(int index,int grade) => designGrades[index] = grade;
      
        public string Secondname
        {
            get => secondname;
            set => secondname = value ?? throw new ArgumentNullException(nameof(value));
        }

        public string Firstname
        {
            get => firstname;
            set => firstname = value ?? throw new ArgumentNullException(nameof(value));
        }

        public string Middlename
        {
            get => middlename;
            set => middlename = value ?? throw new ArgumentNullException(nameof(value));
        }

        public int Group
        {
            get => group;
            set => group = value;
        }

        public int[] ProgrammingGrades
        {
            get => programmingGrades;
            set => programmingGrades = value ?? throw new ArgumentNullException(nameof(value));
        }

        public int[] AdministrationGrades
        {
            get => administrationGrades;
            set => administrationGrades = value ?? throw new ArgumentNullException(nameof(value));
        }

        public int[] DesingGrades
        {
            get => designGrades;
            set => designGrades = value ?? throw new ArgumentNullException(nameof(value));
        }
        
    }
}