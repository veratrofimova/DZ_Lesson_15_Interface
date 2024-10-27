using DZ_Lesson_15_Interface;

Console.WriteLine("Начинаем работать с Интерфейсами");
try
{
    var quadcopter = new Quadcopter();

    Console.WriteLine("\r\nВызов метода GetComponents");
    string returnValue = string.Join(", ", quadcopter.GetComponents());
    Console.WriteLine(returnValue);

    Console.WriteLine("\r\nВызов общего метода GetInfo интерфейсов IRobotable и IChargeable");
    returnValue = quadcopter.GetInfo();
    Console.WriteLine(returnValue);

    Console.WriteLine("\r\nВызов метода GetInfo интерфейса IRobotable");
    IRobotable quadcopterIRobotable = new Quadcopter();
    returnValue = quadcopterIRobotable.GetInfo();
    Console.WriteLine(returnValue);

    Console.WriteLine("\r\nВызов метода GetInfo интерфейса IChargeable");
    IChargeable quadcopterIChargeable = new Quadcopter();
    returnValue = quadcopterIChargeable.GetInfo();
    Console.WriteLine(returnValue);

    Console.WriteLine("\r\nВызов метода GetRobotType интерфейса IFlyingRobotable");
    IFlyingRobotable quadcopterIFlyingRobotable = new Quadcopter();
    returnValue = quadcopterIFlyingRobotable.GetRobotType();
    Console.WriteLine(returnValue);

    Console.WriteLine("\r\nВызов метода GetRobotType интерфейса IRobotable");
    returnValue = quadcopterIRobotable.GetRobotType();
    Console.WriteLine(returnValue);

    Console.WriteLine("\r\nВызов метода Charge");
    quadcopter.Charge();

    Console.WriteLine("\r\nВызов метода Charge интерфейса IChargeable");
    quadcopterIChargeable.Charge();
}
catch (NotImplementedException)
{
    Console.WriteLine("Метод не реализован!");
}
catch (Exception)
{
    throw;
}
