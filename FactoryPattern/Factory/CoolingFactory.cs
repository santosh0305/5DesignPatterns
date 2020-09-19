namespace FactoryPattern
{
    #region Concrete creator classes
    // this is concrete creator classes
    #endregion
    public class CoolingFactory : AirConditionerFactory
    {
        public override IAirConditioner Create(double temperature) => new CoolingManager(temperature);
    }
}
