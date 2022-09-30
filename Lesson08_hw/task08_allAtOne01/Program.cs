using System.ComponentModel;
using PersonalArrayMaster;
using System.Xml;

namespace task08_allAtOne01
{
    internal class Program
    {
        


        private static void Main()
        {
            int userSelect;
            do
            {
                userSelect = UserInterface.GetSelectTask();
                if (userSelect == 1)
                {
                    Task54.Task54Solution();
                }
                if (userSelect == 2)
                {
                    Task56.Task56Solution();
                }
                if (userSelect == 3)
                {
                    Task58.Task58Solution();
                }
                if (userSelect == 4)
                {
                    Task60.Task60Solution();
                }
                if (userSelect == 5)
                {
                    Task62.Task62Solution();
                }
                if (userSelect == 0) break;
            }
            while (true);



        }
    }
}