using UnityEngine;

public class SimulationManager : MonoBehaviour
{
    [SerializeField] private PlanetarySystemViewManager planetarySystemViewManager;
    [SerializeField] [Range(0f, 10f)] private float SimulationSpeed = 1f;
    
    private IPlaneterySystem PlaneterySystem;
    private async void Awake()
    {
        IPlaneterySystemFactory randomFactory = new RandomPlaneterySystemFactory();
        PlaneterySystem = randomFactory.Create();
        await planetarySystemViewManager.Generate(PlaneterySystem);
    }

    private void FixedUpdate()
    {
        Time.timeScale = SimulationSpeed;
        PlaneterySystem.Simulate(Time.fixedDeltaTime);
    }
}
