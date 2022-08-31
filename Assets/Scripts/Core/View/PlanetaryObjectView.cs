using UnityEngine;

public class PlanetaryObjectView : MonoBehaviour
{
    [SerializeField] private Renderer Renderer;

    public void Scale(double _radius)
    {
        float _r = (float) _radius;
        Vector3 _scale = new Vector3(0.0001f, 0.0001f, 0.0001f) + new Vector3(_r, _r, _r);
        transform.localScale = _scale;
    }
    public void Move(Vector3 _position)
    {
        transform.position = new Vector3(0.0001f, 0.0001f, 0.0001f) + _position;
    }
}