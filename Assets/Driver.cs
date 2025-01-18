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
        float steerAmount = Input.GetAxis("Horizontal") * steeringAngle;
        float accelerationAmount = Input.GetAxis("Vertical") * acceleration;
        
        transform.Rotate(0, 0, -steerAmount);
        transform.Translate(0, accelerationAmount, 0);
    }
}
