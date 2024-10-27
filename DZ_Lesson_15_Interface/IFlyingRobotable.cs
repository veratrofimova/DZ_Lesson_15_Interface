namespace DZ_Lesson_15_Interface
{
    public interface IFlyingRobotable : IRobotable
    {
        string GetRobotType()
        {
            return "I am a flying robot.";
        }
    }
}
