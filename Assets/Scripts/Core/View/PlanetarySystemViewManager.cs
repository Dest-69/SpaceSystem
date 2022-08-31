using System;
using System.Threading.Tasks;
using UnityEngine;
using UnityEngine.AddressableAssets;
using UnityEngine.ResourceManagement.AsyncOperations;

public class PlanetarySystemViewManager : MonoBehaviour
{
    public async Task Generate(IPlaneterySystem PlaneterySystem)
    {
        foreach (IPlaneteryObject planeteryObject in PlaneterySystem.PlaneteryObjects)
        {
            string _name = Enum.GetName(typeof(classSpecificationsEnum), planeteryObject.ClassSpecificationsEnum);
            
            AsyncOperationHandle<GameObject> handle = Addressables.InstantiateAsync(_name);
            await handle.Task;
            if (handle.Status != AsyncOperationStatus.Succeeded)
            {
                Debug.LogError("__Not spawned__");
                continue;
            }
            
            PlanetaryObjectView planetaryObjectView = handle.Result.GetComponent<PlanetaryObjectView>();
            planetaryObjectView.Scale(planeteryObject.Radius);
            planetaryObjectView.Move(planeteryObject.Position);

            
            planeteryObject.OnPositionChange += planetaryObjectView.Move;
            planeteryObject.OnRadiusChange += planetaryObjectView.Scale;
        }
    }
}