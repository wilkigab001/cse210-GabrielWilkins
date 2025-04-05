public class BreathingActivity : Activity
{
    public BreathingActivity() : base("Breathing", "This activity will help you relax by walking you through breathing in and out slowly. Clear your mind and focus on your breathing.") { }

    protected override void PerformActivity()
    {
        int time = GetDuration();
        while (time > 0)
        {
            Console.WriteLine("\nBreathe in...");
            Countdown(4);
            time -= 4;
            if (time <= 0) break;

            Console.WriteLine("Breathe out...");
            Countdown(4);
            time -= 4;
        }
    }
}
