
abstract class Goal
{
    private string _name;
    private string _description;
    private int _numberOfPoints;
    private bool _status;
    private string _goalType;

    public Goal()
    {
        _name = "";
        _description = "";
        _status = false;
        _numberOfPoints = 0;
        _goalType = "";
    }

    public void SetName()
    {
        Console.Write("Please the enter name of your goal: ");
        _name = Console.ReadLine();
    }

    public void SetDescription()
    {
        Console.Write("Please the enter description of your goal: ");
        _description = Console.ReadLine();
    }

    public void SetPoints()
    {
        Console.Write("Please the enter Points for your goal: ");
        _numberOfPoints = int.Parse(Console.ReadLine());
    }
 
    public virtual string GetConsoleString()
    {
        return $"Goal Information: {_name}, {_description}, {_numberOfPoints}";
    }

    public abstract void CreateGoal();

}