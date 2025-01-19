using UnityEngine;

public class Delivery : MonoBehaviour
{
    private bool _hasPackage;
    void OnCollisionEnter2D(Collision2D collision)
    {
        Debug.Log("Collision detected!");
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Package"))
        {
            Debug.Log("Package picked up!");
            _hasPackage = true;
        }
        
        if (other.CompareTag("Customer") && _hasPackage)
        {
            Debug.Log("Package delivered!");
            _hasPackage = false;
        }
    }
} 
