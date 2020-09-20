namespace FactoryMethod
{
    #region Concrete creator classes
    // this is concrete creator classes
    #endregion
    public class CoolingFactory : AirConditionerFactory
    {
        public override IAirConditioner Create(double temperature)
        {
            return new CoolingManager(temperature);
        }
    }
}
