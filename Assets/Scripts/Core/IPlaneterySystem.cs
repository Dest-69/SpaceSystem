using System.Collections.Generic;

public abstract class IPlaneterySystem
{
    public abstract IEnumerable<IPlaneteryObject> PlaneteryObjects { get; set; }
    public abstract void Simulate(float deltaTime);
}
