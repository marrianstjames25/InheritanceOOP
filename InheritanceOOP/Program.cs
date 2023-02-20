using System;


namespace InheritanceOOP
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Student s1 = new Student("Joe", "CS", 4.0);

            StudentMPhysics smp = new StudentMPhysics("John", "MathsPhysics", 5.0, 65.3, 66.6, 78.8);

            smp.Intro();


        }

        class Student //base class
        {
            public string name;
            public string profile;
            public double GPA;


            public Student(string name, string profile, double GPA)
            {
                this.name = name;
                this.profile = profile;
                this.GPA = GPA;
            }

            public virtual void Intro()
            {
                Console.WriteLine($"Hello my name is {name}, I am a student from {profile} profile and my  GPA is: {GPA}");
            }
        }

            class StudentMPhysics : Student //derived class
        { 

                public double MathGrade;
                public double PhysicsGrade;
                public double InformaticsGrade;

            public StudentMPhysics(string name, string profile, double GPA, double MathGrade, double PhysicsGrade, double InformaticsGrade) : base(name,profile, GPA)
            {
                this.MathGrade = MathGrade;
                this.PhysicsGrade = PhysicsGrade;
                this.InformaticsGrade = InformaticsGrade;
                
                base.Intro();
            }


            public override void Intro()
            {
                Console.WriteLine($"Hello my name is {name}, I am a student from {profile} profile and my  GPA is: {GPA} and my math grade is {MathGrade} , my Informatics grade is{InformaticsGrade} and my Physics grade is {PhysicsGrade} ");
            }


        }
        }
    
}
