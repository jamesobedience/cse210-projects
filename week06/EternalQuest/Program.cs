using System;

class Program
{
    static void Main(string[] args)
    {
        GoalManager manager = new();
        Console.WriteLine("Welcome to Eternal Quest!");

        bool running = true;
        while (running)
        {

            Console.WriteLine("\nEternal Quest Menu:");
            Console.WriteLine("1. Create New Goal");
            Console.WriteLine("2. List Goals");
            Console.WriteLine("3. Record Event");
            Console.WriteLine("4. Show Score");
            Console.WriteLine("5. Save Goals");
            Console.WriteLine("6. Load Goals");
            Console.WriteLine("7. Quit");

            Console.Write("Select an option: ");
            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    CreateGoal(manager);
                    break;
                case "2":
                    manager.ShowGoals();
                    break;
                case "3":
                    manager.ShowGoals();
                    Console.Write("Which goal did you accomplish? ");
                    int goalIndex = int.Parse(Console.ReadLine()) - 1;
                    manager.RecordEvent(goalIndex);
                    break;
                case "4":
                    manager.ShowScore();
                    break;
                case "5":
                    Console.Write("Filename to save: ");
                    manager.SaveGoals(Console.ReadLine());
                    break;
                case "6":
                    Console.Write("Filename to load: ");
                    manager.LoadGoals(Console.ReadLine());
                    break;
                case "7":
                    running = false;
                    break;
            }
        }
    }

    static void CreateGoal(GoalManager manager)
    {
        Console.WriteLine("Select goal type:\n1. Simple\n2. Eternal\n3. Checklist\n4. Negative");
        string type = Console.ReadLine();

        Console.Write("Goal name: ");
        string name = Console.ReadLine();
        Console.Write("Description: ");
        string desc = Console.ReadLine();
        Console.Write("Points: ");
        int points = int.Parse(Console.ReadLine());

        switch (type)
        {
            case "1":
                manager.AddGoal(new SimpleGoal(name, desc, points));
                break;
            case "2":
                manager.AddGoal(new EternalGoal(name, desc, points));
                break;
            case "3":
                Console.Write("Target count: ");
                int target = int.Parse(Console.ReadLine());
                Console.Write("Bonus points: ");
                int bonus = int.Parse(Console.ReadLine());
                manager.AddGoal(new ChecklistGoal(name, desc, points, target, bonus));
                break;
            case "4":
                manager.AddGoal(new NegativeGoal(name, desc, points));
                break;
        }
    }
}
// This is the main entry point for the Eternal Quest application.

