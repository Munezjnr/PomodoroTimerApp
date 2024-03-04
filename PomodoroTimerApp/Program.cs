namespace PomodoroTimerApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Pomodoro timer****");

             PomodoroTimer pomodoroTimer = new PomodoroTimer();
             pomodoroTimer.StartPomodoro();
        }

    }
}

