using System;
using System.Collections.Generic;
public class ChecklistGoal : Goal
{
    private int _targetCount;
    private int _currentCount;
    private int _bonus;

    public ChecklistGoal(string name, string description, int points, int targetCount, int bonus)
        : base(name, description, points)
    {
        _targetCount = targetCount;
        _currentCount = 0;
        _bonus = bonus;
    }

    public override int RecordEvent()
    {
        if (_currentCount < _targetCount)
        {
            _currentCount++;
            if (_currentCount == _targetCount)
            {
                return _points + _bonus;
            }
            return _points;
        }
        return 0;
    }

    public override bool IsComplete() => _currentCount >= _targetCount;

    public override string GetStatus() =>
        $"[{(IsComplete() ? "X" : " ")}] {_name} ({_description}) -- Completed {_currentCount}/{_targetCount}";

    public override string GetStringRepresentation() =>
        $"ChecklistGoal|{_name}|{_description}|{_points}|{_bonus}|{_targetCount}|{_currentCount}";
}
