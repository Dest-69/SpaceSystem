using UnityEngine;

public class StandartPlaneterySunObject : IPlaneteryObject
{
    public override double Mass { get; set; }
    public override double Radius
    {
        get => radius;
        set 
        {
            radius = value;
            OnRadiusChange?.Invoke(radius);
        }
    }
    private double radius;
    public override event OnRadiusChangeDelegate OnRadiusChange;
    
    public override classSpecificationsEnum ClassSpecificationsEnum { get; set; }
    public override Vector3 Position
    {
        get => position;
        set 
        {
            position = value;
            OnPositionChange?.Invoke(position);
        }
    }
    private Vector3 position;
    public override event OnPositionChangeDelegate OnPositionChange;
    
    
    public override Vector3 Force { get; set; }
    public override IPlaneterySystem planeterySystem { get; set; }

    public StandartPlaneterySunObject(double _mass, double _radius, classSpecificationsEnum _classSpecificationsEnum,
        IPlaneterySystem _planeterySystem) : base(_mass, _radius, _classSpecificationsEnum, _planeterySystem)
    {
    }

    public override void Calculate()
    {
        
    }
    public override void Move(float deltaTime)
    {
        
    }
}