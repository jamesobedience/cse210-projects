public class NegativeGoal : Goal
{
    public NegativeGoal(string name, string description, int points)
        : base(name, description, points)
    {
    }

    public override int RecordEvent()
    {
        return -_points;
    }

    public override bool IsComplete()
    {
        return false; 
    }

    public override string GetStatus()
    {
        return $"[!] {_name} ({_description}) — Lose {_points} points when recorded";
    }

    public override string GetStringRepresentation()
    {
        return $"NegativeGoal|{_name}|{_description}|{_points}";
    }
}
// This class represents a goal that deducts points when recorded, useful for tracking negative outcomes or penalties.