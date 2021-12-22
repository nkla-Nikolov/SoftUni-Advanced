using System;
using System.Collections.Generic;
using System.Linq;

namespace AverageStudentGrades
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            
            Dictionary<string, List<decimal>> grades = new Dictionary<string, List<decimal>>();

            for (int i = 0; i < n; i++)
            {
                string[] arguments = Console.ReadLine().Split();
                string studentName = arguments[0];
                decimal grade = decimal.Parse(arguments[1]);

                if (!grades.ContainsKey(studentName))
                {
                    grades.Add(studentName, new List<decimal>());
                }
                
                grades[studentName].Add(grade);
            }

            foreach (var student in grades)
            {
                Console.WriteLine($"{student.Key} -> {string.Join(" ", student.Value.Select(x => $"{x:f2}"))} (avg: {student.Value.Average():f2})");
            }
        }
    }
}
