namespace DZ_Lesson_15_Interface
{
    public interface IRobotable
    {
        public string GetInfo();
        public List<string> GetComponents();
        string GetRobotType()
        {
            return "I am a simple robot.";
        }
    }
}
