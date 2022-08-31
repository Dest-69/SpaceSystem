using System.Collections.Generic;

public class StandartPlaneterySystem : IPlaneterySystem
{
    public override IEnumerable<IPlaneteryObject> PlaneteryObjects { get; set; }
    public override void Simulate(float deltaTime)
    {
        foreach (IPlaneteryObject pObj in PlaneteryObjects)
        {
            pObj.Calculate();
        }
        foreach (IPlaneteryObject pObj in PlaneteryObjects)
        {
            pObj.Move(deltaTime);
        }
    }
}
