namespace Task09AllAtOne
{
    public class Program
    {
        static void Main(string[] args)
        {
            int userSelect;
            do
            {
                userSelect = UserInterface.GetSelectTask();
                if (userSelect == 1)
                {
                    Task64.Task64Solution();
                }
                if (userSelect == 2)
                {
                    Task66.Task66Solution();
                }
                if (userSelect == 3)
                {
                    Task68.Task68Solution();
                }
                if (userSelect == 0) break;
            }
            while (true);
        }
    }
}