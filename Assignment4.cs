using System;
using System.Dynamic;

namespace ConsoleApp4
{
    class Program
    {
        public class BooleanCourse1 : Project
        {
            static bool Bool1PassedGrade { get; set; } = true;
            public static bool Bool1Passed { get; set; } = false;
            public static void PassedBool1(string[] args)
            {
                if (Bool1PassedGrade == true)
                {
                    Bool1Passed = true;
                    
                }
            }
            
        }
        public class BooleanCourse2 : Project
        {
            static bool Bool2PassedGrade { get; set; } = true;
            public static bool Bool2Passed { get; set; } = false;
            public static void PassedBool2(string[] args)
            {
                if (Bool2PassedGrade == true)
                {
                    Bool2Passed = true;
                }
            }

        }

        public class GradedCourse1 : Project
        {
            static int Course1Grade { get; set; } = 3;
            public static bool Graded1Passed { get; set; } = false;
            public static void PassedGraded1(string[] args)
            {
                if (Course1Grade >= 2)
                {
                    Graded1Passed = true;
                }
            }
        }
        public class GradedCourse2 : Project
        {
            static int Course2Grade { get; set; } = 3;
            public static bool Graded2Passed { get; set; } = false;
            public static void PassedGraded2(string[] args)
            {
                if (Course2Grade >= 2)
                {
                    Graded2Passed = true;
                }
            }
        }

        public class Project {

            static void Main(string[] args)
                
            {
                int Passed1 = 0;
                int Passed2 = 0;
                int Passed3 = 0;
                int Passed4 = 0;
                GradedCourse1.PassedGraded1(args);
                if (GradedCourse1.Graded1Passed == true)
                {
                    Passed1 = 1;
                }
                GradedCourse2.PassedGraded2(args);
                if (GradedCourse2.Graded2Passed == true)
                {
                    Passed2 = 1;
                }
                BooleanCourse1.PassedBool1(args);
                if (BooleanCourse1.Bool1Passed == true)
                {
                    Passed3 = 1;
                }
                BooleanCourse2.PassedBool2(args);
                if (BooleanCourse2.Bool2Passed == true)
                {
                    Passed4 = 1;
                }

                if (Passed1 + Passed2 + Passed3 + Passed4 >= 3) 
                {
                    Console.WriteLine("You had passed at least 3 out from the 4 groups");
                    Console.Read();
                }
                else
                {
                    Console.WriteLine("You haven't passed eniough courses");
                    Console.Read();
                }
            }
        }

    }
}
