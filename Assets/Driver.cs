using UnityEngine;

public class Driver : MonoBehaviour
{
    [SerializeField] int steeringAngle = 300;
    [SerializeField] int acceleration = 20;

    void Start()
    {
        
    }
    
    private void Update()
    {
        float steerAmount = Input.GetAxis("Horizontal") * steeringAngle * Time.deltaTime;
        float accelerationAmount = Input.GetAxis("Vertical") * acceleration * Time.deltaTime;
        
        transform.Rotate(0, 0, -steerAmount);
        transform.Translate(0, accelerationAmount, 0);
    }
}
