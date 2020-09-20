namespace FactoryMethod
{
    #region ConcreteFactory
    // Factory 2 inheriting Base Factory
    #endregion
    public class WarmingFactory : AirConditionerFactory
    {
        public override IAirConditioner Create(double temperature)
        {
            return new WarmingManager(temperature);
        }
    }
}
