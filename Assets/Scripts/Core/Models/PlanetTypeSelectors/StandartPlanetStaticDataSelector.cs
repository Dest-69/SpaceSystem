using UnityEngine;

public class StandartPlanetStaticDataSelector : IPlanetStaticDataSelector
{
    private readonly PlanetClass[] PlanetClasses = new PlanetClass[]
    {
        new PlanetClass // Asteroidan
        {
            minMass = 0.000000001f,
            maxMass = 0.00001f,
            minRadius = 0.000000001f,
            maxRadius = 0.03f
        },
        new PlanetClass // Mercurian
        {
            minMass = 0.00001f,
            maxMass = 0.1f,
            minRadius = 0.03f,
            maxRadius = 0.7f
        },
        new PlanetClass // Subterran
        {
            minMass = 0.1f,
            maxMass = 0.5f,
            minRadius = 0.5f,
            maxRadius = 1.2f
        },
        new PlanetClass // Terran
        {
            minMass = 0.5f,
            maxMass = 2f,
            minRadius = 0.8f,
            maxRadius = 1.9f
        },
        new PlanetClass // Superterran
        {
            minMass = 2f,
            maxMass = 10f,
            minRadius = 1.3f,
            maxRadius = 3.3f
        },
        new PlanetClass // Neptunian
        {
            minMass = 10f,
            maxMass = 50f,
            minRadius = 2.1f,
            maxRadius = 5.7f
        },
        new PlanetClass // Jovian
        {
            minMass = 50f,
            maxMass = 5000f,
            minRadius = 3.5f,
            maxRadius = 27f
        }
    };
    
    public (classSpecificationsEnum, double, double) GetPlanetStaticData()
    {
        int index = Random.Range(0, PlanetClasses.Length);
        double _mass = Random.Range((float) PlanetClasses[index].minMass, (float) PlanetClasses[index].maxMass);
        double progress = _mass / (PlanetClasses[index].maxMass - PlanetClasses[index].minMass);
        double _radius = (PlanetClasses[index].maxRadius - PlanetClasses[index].minRadius) * progress;

        return index switch
        {
            0 => (classSpecificationsEnum.Asteroidan, _radius, _mass),
            1 => (classSpecificationsEnum.Mercurian, _radius, _mass),
            2 => (classSpecificationsEnum.Subterran, _radius, _mass),
            3 => (classSpecificationsEnum.Terran, _radius, _mass),
            4 => (classSpecificationsEnum.Superterran, _radius, _mass),
            5 => (classSpecificationsEnum.Neptunian, _radius, _mass),
            6 => (classSpecificationsEnum.Jovian, _radius, _mass),
            _ => (classSpecificationsEnum.Asteroidan, 0, 0)
        };
    }

    public PlanetClass[] GetPlanetStatic()
    {
        return PlanetClasses;
    }
    
    public class PlanetClass
    {
        public double minMass;
        public double maxMass;
        public double minRadius;
        public double maxRadius;
    }
}