using UnityEngine;

public abstract class IPlaneteryObjectFactory
{
    public abstract IPlaneteryObject Create(double mass, Vector3 position, Vector3 force);
    public abstract void SetForce(Vector3 force);
    public abstract void SetPosition(Vector3 position);
}
