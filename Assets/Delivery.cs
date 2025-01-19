using UnityEngine;

public class Delivery : MonoBehaviour
{
    void OnCollisionEnter2D(Collision2D collision)
    {
        Debug.Log("Collision detected!");
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Package"))
        {
            Debug.Log("Package picked up!");
        }
        
        if (other.CompareTag("Customer"))
        {
            Debug.Log("Package delivered!");
        }
    }
} 
