using System;

namespace _02._Exam_Preparation
{
    class Program
    {
        static void Main(string[] args)
        {
            int failedGrades = int.Parse(Console.ReadLine());
            int failedTimes = 0;
            int solvedProblems = 0;
            double gradeSum = 0;
            string lastProblem = "";
            bool IsFailed = true;
            //o"Number of problems: {броя на всички задачи}"
            //o "Last problem: {името на последната задача}"
            //•	Ако получи определеният брой незадоволителни оценки:
            //o"You need a break, {брой незадоволителни оценки} poor grades."

            while (failedGrades > failedTimes)
            {
                string problemName = Console.ReadLine();
                if (problemName == "Enough")
                {
                    IsFailed = false;
                    break;
                }
                int grade = int.Parse(Console.ReadLine());
                if (grade<=4)
                {
                    failedTimes++;
                }
                gradeSum += grade;
                solvedProblems++;
                lastProblem = problemName;
            }
            if (IsFailed)
            {
                Console.WriteLine($"You need a break, {failedGrades} poor grades.");
            }
            else
            {
                Console.WriteLine($"Average score: {gradeSum/solvedProblems:F2}");
                Console.WriteLine($"Number of problems: {solvedProblems}");
                Console.WriteLine($"Last problem: {lastProblem}");
            }
        }
    }
}
