using System.Collections.Generic;
using UnityEngine;

public class RandomPlaneterySystemFactory : IPlaneterySystemFactory
{
    private const int minObjectsCount = 10;
    private const int maxObjectsCount = 24;

    public override IPlaneterySystem Create()
    {
        IPlaneterySystem standartSystem = new StandartPlaneterySystem();
        IPlanetStaticDataSelector planetStaticDataSelector = new StandartPlanetStaticDataSelector();
        
        List<IPlaneteryObject> planeteryObjects = new List<IPlaneteryObject>();
        IPlaneteryObject sunObj = new StandartPlaneterySunObject(20000f, 20f,
            classSpecificationsEnum.Sun, standartSystem);
        sunObj.Position = Vector3.zero;
        sunObj.Force = Vector3.zero;
        planeteryObjects.Add(sunObj);
        
        int planetsCount = Random.Range(minObjectsCount, maxObjectsCount);
        
        for (int i = 0; i < planetsCount; i++)
        {
            // need to be separaded, but i no have time
            (classSpecificationsEnum _class, double _radius, double _mass) = planetStaticDataSelector.GetPlanetStaticData();

            IPlaneteryObject _planeteryObj = new StandartPlaneteryObject(_mass, _radius, _class, standartSystem);
            
            _planeteryObj.Position = new Vector3(Random.Range(-100f, 100f), 0, Random.Range(-100f, 100f));
            int dir = Random.Range(0, 2) == 0 ? -1 : 1;
            Vector3 dirrection = Quaternion.Euler(0, 90 * dir, 0) * -_planeteryObj.Position.normalized;
            double distance = (sunObj.Position - _planeteryObj.Position).sqrMagnitude;
            double gravityForce = sunObj.Mass * _planeteryObj.Mass / distance;
            _planeteryObj.Force = dirrection * (float)gravityForce * 10f;
            
            planeteryObjects.Add(_planeteryObj);
        }

        standartSystem.PlaneteryObjects = planeteryObjects;

        return standartSystem;
    }
}
