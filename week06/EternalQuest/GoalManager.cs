using System;
using System.Collections.Generic;

public class GoalManager
{
    private List<Goal> _goals = new();
    private int _score = 0;

    public void AddGoal(Goal goal) => _goals.Add(goal);

    public void RecordEvent(int index)
    {
        int points = _goals[index].RecordEvent();
        _score += points;
        Console.WriteLine($"You earned {points} points! Total score: {_score}");
    }

    public void ShowGoals()
    {
        for (int i = 0; i < _goals.Count; i++)
        {
            Console.WriteLine($"{i + 1}. {_goals[i].GetStatus()}");
        }
    }

    public void ShowScore() => Console.WriteLine($"Your score: {_score}");

    public void SaveGoals(string filename)
    {
        using (StreamWriter writer = new(filename))
        {
            writer.WriteLine(_score);
            foreach (Goal goal in _goals)
            {
                writer.WriteLine(goal.GetStringRepresentation());
            }
        }
    }

    public void LoadGoals(string filename)
    {
        if (File.Exists(filename))
        {
            string[] lines = File.ReadAllLines(filename);
            _score = int.Parse(lines[0]);
            _goals.Clear();

            foreach (string line in lines.Skip(1))
            {
                string[] parts = line.Split('|');
                string type = parts[0];
                switch (type)
                {
                    case "SimpleGoal":
                        AddGoal(new SimpleGoal(parts[1], parts[2], int.Parse(parts[3])) 
                        { 
                            // Assuming it's not complete already
                        });
                        break;
                    case "EternalGoal":
                        AddGoal(new EternalGoal(parts[1], parts[2], int.Parse(parts[3])));
                        break;
                    case "ChecklistGoal":
                        var goal = new ChecklistGoal(parts[1], parts[2], int.Parse(parts[3]),
                                                      int.Parse(parts[5]), int.Parse(parts[4]));
                        typeof(ChecklistGoal).GetField("_currentCount", 
                          System.Reflection.BindingFlags.NonPublic | System.Reflection.BindingFlags.Instance)
                          ?.SetValue(goal, int.Parse(parts[6]));
                        AddGoal(goal);
                        break;
                }
            }
        }
    }
}

