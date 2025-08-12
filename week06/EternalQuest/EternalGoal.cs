using System;
using System.Collections.Generic;

public class EternalGoal : Goal
{
    public EternalGoal(string name, string description, int points)
        : base(name, description, points)
    {
    }

    public override int RecordEvent() => _points;

    public override bool IsComplete() => false;

    public override string GetStatus() => $"[∞] {_name} ({_description})";

    public override string GetStringRepresentation() =>
        $"EternalGoal|{_name}|{_description}|{_points}";
}
// This class represents a goal that can be completed multiple times, earning points each time.
