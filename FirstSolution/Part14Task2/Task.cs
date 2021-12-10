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
            Console.WriteLine(student1.CountAverageGrade(student1.ProgrammingGrades));
            Console.WriteLine(student1.CountAverageGrade(student1.AdministrationGrades));
            Console.WriteLine(student1.CountAverageGrade(student1.DesingGrades));
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
        private int[] desingGrades;

        public Student(string secondname, string firstname, string middlename, int group, int[] programmingGrades,
            int[] administrationGrades, int[] desingGrades)
        {
            this.secondname = secondname;
            this.firstname = firstname;
            this.middlename = middlename;
            this.group = group;
            this.programmingGrades = programmingGrades;
            this.administrationGrades = administrationGrades;
            this.desingGrades = desingGrades;
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
            
            for (int i = 0; i < desingGrades.Length; i++)
            {
                Console.Write(desingGrades[i] + " ");
            }
            Console.WriteLine();
        }

        public float CountAverageGrade(int[] programmingGrades)
        {
            float sum = 0;
            
            for (int i = 0; i < programmingGrades.Length; i++)
            {
                sum += programmingGrades[i];
            }

            float averageScore = sum / programmingGrades.Length;
            Console.WriteLine("Average programming grade");
            return averageScore;
        }
        
        public int GetProgrammingGrade()
        {
            return programmingGrades[2];
        }
        
        public void SetProgrammingGrade(int grade)
        {
            programmingGrades[2] = grade;
        }
        
        
        public int GetAdministrationGrade()
        {
             return programmingGrades[2];
        }
        
        public void SetAdministrationGrade(int grade)
        {
            programmingGrades[2] = grade;
        }
        
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
            get => desingGrades;
            set => desingGrades = value ?? throw new ArgumentNullException(nameof(value));
        }
        
    }
}