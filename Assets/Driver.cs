using UnityEngine;

public class Driver : MonoBehaviour
{
    private readonly float _steeringAngle = 1f;
    private readonly float _acceleration = 0.01f;

    void Start()
    {
        
    }
    
    private void Update()
    {
        transform.Rotate(0, 0, _steeringAngle);
        transform.Translate(0, _acceleration, 0);
    }
}
