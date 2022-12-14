public class AsteroidanObject : StandartPlaneteryObject
{
    public AsteroidanObject(double _mass, double _radius, classSpecificationsEnum _classSpecificationsEnum,
        IPlaneterySystem _planeterySystem) : base(_mass, _radius, _classSpecificationsEnum, _planeterySystem)
    {
    }
    
    public override void Calculate()
    {
        base.Calculate();
    }
    public override void Move(float deltaTime)
    {
        base.Move(deltaTime);
    }
}