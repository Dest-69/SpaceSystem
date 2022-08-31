using UnityEngine;

public abstract class IPlaneteryObject : IMovable
{
    public abstract double Mass { get; set; }
    public abstract double Radius { get; set; }
    public delegate void OnRadiusChangeDelegate(double newRadius);
    public abstract event OnRadiusChangeDelegate OnRadiusChange;
    public abstract classSpecificationsEnum ClassSpecificationsEnum { get; set; }
    public abstract Vector3 Position { get; set; }
    public delegate void OnPositionChangeDelegate(Vector3 newPos);
    public abstract event OnPositionChangeDelegate OnPositionChange;
    public abstract Vector3 Force { get; set; }
    public abstract IPlaneterySystem planeterySystem { get; set; }
    
    protected IPlaneteryObject(double _mass, double _radius, classSpecificationsEnum _classSpecificationsEnum, IPlaneterySystem _planeterySystem)
    {
        Mass = _mass;
        Radius = _radius;
        ClassSpecificationsEnum = _classSpecificationsEnum;
        planeterySystem = _planeterySystem;
    }
    
    public abstract void Calculate();
    public abstract void Move(float deltaTime);
}
