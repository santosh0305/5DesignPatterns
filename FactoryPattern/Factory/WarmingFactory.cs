namespace FactoryMethod
{
    #region Concrete creator classes
    // this is concrete creator classes
    #endregion
    public class WarmingFactory : AirConditionerFactory
    {
        public override IAirConditioner Create(double temperature)
        {
            return new WarmingManager(temperature);
        }
    }
}
