using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OK_Task5
{
    class Program
    {

        private static List<Task> tasks  = new List<Task>();

        public class Task
        {
            public string Name;
            public int Priority;
            public int Complexity;
            public int Time;
          

            public void setComplexity(int compl)
            {
                this.Complexity = compl;
                if (compl == 1) this.Time = 4;
                else
                    if (compl == 2) this.Time = 2;
                else
                    if (compl == 3) this.Time = 1;
            }
        }

        public class PriorityFirst : IComparer<Task>
        {
           public int Compare(Task x, Task y)
            {
                return x.Priority - y.Priority;
            }
        }

        static void PrintTime()
        {
            int sum = 0;
            foreach (Task task in tasks)
                {
                    sum += task.Time; 
                }
            Console.WriteLine("Total time for all tasks = {0}",sum);
        }

        static void PrintTaskByPriority()
        {
            Console.WriteLine("Input task priority: ");
            int pr = Convert.ToInt32(Console.ReadLine());

            bool b = false;

            foreach (Task task in tasks)
            {
                if (task.Priority == pr)
                {
                    Console.WriteLine(task.Name);
                    b = true;
                }
            }
            if (b == false) Console.WriteLine("Task with priority {0} is not found",pr);
        }


        static void PrintTasksPerDays()
        {
            Console.WriteLine("Input days quantity: ");
            int days = Convert.ToInt32(Console.ReadLine());
            int hours = days * 8;
            tasks.Sort(new PriorityFirst());

            Console.WriteLine("Tasks list by priority:");
            foreach (Task task in tasks)
            {
                hours -= task.Time;
                if (hours < 0) break;
                Console.WriteLine(task.Name);
            }          
        }


        static void Main(string[] args)
        {
            Console.WriteLine("Input number of tasks: ");
            int n = Convert.ToInt32(Console.ReadLine());
          
            for (int i = 0; i < n; i++)
            {
                Task t = new Task();

                Console.WriteLine("Input task name: ");
                t.Name = Console.ReadLine();

                Console.WriteLine("Input task priority (1-High, 2-Medium, 3-Low): ");
                t.Priority = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Input task complexity (1-Complex, 2-Medium, 3-Low): ");
                t.setComplexity(Convert.ToInt32(Console.ReadLine()));

                tasks.Add(t);
            }

            PrintTime();
            PrintTaskByPriority();
            PrintTasksPerDays();

            Console.ReadKey();
        }
    }
}
