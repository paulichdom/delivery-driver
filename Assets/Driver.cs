using UnityEngine;

public class Driver : MonoBehaviour
{
    [SerializeField] float steeringAngle = 1f;
    [SerializeField] float acceleration = 0.01f;

    void Start()
    {
        
    }
    
    private void Update()
    {
        transform.Rotate(0, 0, steeringAngle);
        transform.Translate(0, acceleration, 0);
    }
}
