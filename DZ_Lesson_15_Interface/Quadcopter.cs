namespace DZ_Lesson_15_Interface
{
    public class Quadcopter : IFlyingRobotable, IChargeable
    {
        List<string> _components = new List<string> { "rotor1", "rotor2", "rotor3", "rotor4" };

        public void Charge()
        {
            Console.WriteLine("Charging...");
            Thread.Sleep(3000);
            Console.WriteLine("Charged!");
        }

        public List<string> GetComponents()
        {
            return _components;
        }

        void IChargeable.Charge()
        {
            throw new NotImplementedException();
        }

        public string GetInfo()
        {
            return "Реализация GetInfo интерфейсов IRobotable и IChargeable";
        }

        string IChargeable.GetInfo()
        {
            return "Реализация GetInfo интерфейса IChargeable";
        }

        string IRobotable.GetInfo()
        {
            return "Реализация GetInfo интерфейса IRobotable";
        }
    }
}
