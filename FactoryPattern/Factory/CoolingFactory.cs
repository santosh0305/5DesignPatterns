namespace FactoryMethod
{
    #region ConcreteFactory
    // Factory 1 inheriting Base Factory
    #endregion
    public class CoolingFactory : AirConditionerFactory
    {
        public override IAirConditioner Create(double temperature)
        {
            return new CoolingManager(temperature);
        }
    }
}
