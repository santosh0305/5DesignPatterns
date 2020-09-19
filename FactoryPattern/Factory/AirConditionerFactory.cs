namespace FactoryPattern
{
    #region Factory Abstract Class
    // this is Factory Abstract Class
    #endregion
    public abstract class AirConditionerFactory
    {
        public abstract IAirConditioner Create(double temperature);
    }
}
