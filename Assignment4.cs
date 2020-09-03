using System;

namespace ConsoleApplication1
{

    public class BooleanCourse : Project
    {
        public static long Grade1 = -2;
        public static long Grade2 = -2;
        public static long Grade3 = -2;
        public static long Grade4 = -2;

        private static bool PassedBool1 {get; set; } = false;
        private static bool PassedBool2 {get; set; } = false;
        private static bool PassedBool3 { get; set; } = false;
        private static bool PassedBool4 { get; set; } = false;
        
        static void calc(bool[] args)
        {
            if (Grade1 >= 2)
            {

                PassedBool1 = true;
                return;
            }
            else
            {
                PassedBool1 = false;
                return;
            }

            if (Grade2 >= 2)
            {
                PassedBool2 = true;
            }
            else
            {
                PassedBool2 = false;
            }
        }
    }

    public class BooleanCourse1 : BooleanCourse
    {
        
    }
    public class BooleanCourse2 : BooleanCourse
    {
        public bool passedBoll2 = false;
    }

    public class GradedCourse : Project
    {
        public bool PassedGrade = false;
    }

    
    public class Project
    {
        
    }
}
