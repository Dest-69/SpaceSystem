using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class UIManager : MonoBehaviour
{
    [SerializeField] private SimulationManager simulationManager;
    [SerializeField] private Slider zoomSlider;
    [SerializeField] private Slider simSpeedSlider;
    [SerializeField] private Button restartBut;
    [SerializeField] private Camera gameCamera;

    private float defaultCamSize;
    private void Start()
    {
        restartBut.onClick.AddListener(RestartScene);

        if (gameCamera != null)
        {
           defaultCamSize = gameCamera.orthographicSize;
                   zoomSlider.onValueChanged.AddListener(ZoomInOut); 
        }
        if (simulationManager != null)
        {
            simSpeedSlider.onValueChanged.AddListener(SimSpeed);
        }
    }

    private static void RestartScene()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    private void SimSpeed(float value)
    {
        simulationManager.SimulationSpeed = value;
    }
    
    private void ZoomInOut(float value)
    {
        gameCamera.orthographicSize = defaultCamSize / value;
    }
}
