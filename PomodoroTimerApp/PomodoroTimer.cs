using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PomodoroTimerApp
{
    public class PomodoroTimer
    {

        private int workDuration = 25;
        private int restDuration = 5;

        public void StartPomodoro()
        {
            Console.WriteLine("Pomodoro Timer");
            Console.WriteLine("Press Enter to start the timer...");

            Console.ReadLine();

            while (true)
            {
                WorkSession();
                RestSession();
            }
        }

        private void WorkSession()
        {
            Console.Clear();
            Console.WriteLine($"Work Session ({workDuration} minutes)");
            Timer(workDuration);
            Console.WriteLine("Time's up! Take a break.");
        }

        private void RestSession()
        {
            Console.WriteLine("Press Enter to start the rest session...");

            Console.ReadLine();
            Console.Clear();
            Console.WriteLine($"Rest Session ({restDuration} minutes)");
            Timer(restDuration);
            Console.WriteLine("Time's up! Get back to work.");
        }

        private void Timer(int minutes)
        {
            int totalSeconds = minutes * 60;

            while (totalSeconds > 0)
            {
                Console.WriteLine($"Time Remaining: {TimeSpan.FromSeconds(totalSeconds)}");
                Thread.Sleep(1000);
                totalSeconds--;
                Console.Clear();
            }
        }
    }

}

