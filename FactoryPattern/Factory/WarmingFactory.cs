namespace FactoryPattern
{
    #region Concrete creator classes
    // this is concrete creator classes
    #endregion
    public class WarmingFactory : AirConditionerFactory
    {
        public override IAirConditioner Create(double temperature) => new WarmingManager(temperature);
    }
}
