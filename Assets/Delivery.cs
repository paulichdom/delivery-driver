using UnityEngine;

public class Delivery : MonoBehaviour
{
    [SerializeField] Color32 hasPackageColor = new Color32(1, 1, 1, 1);
    [SerializeField] Color32 noPackageColor = new Color32(1, 1, 1, 1);
    
    private bool _hasPackage;
    [SerializeField] float destroyDelay = 0.5f;
    
    SpriteRenderer spriteRenderer;

    void Start()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
    }
    
    void OnCollisionEnter2D(Collision2D collision)
    {
        Debug.Log("Collision detected!");
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Package") && !_hasPackage)
        {
            Debug.Log("Package picked up!");
            _hasPackage = true;
            spriteRenderer.color = hasPackageColor;
            Destroy(other.gameObject, destroyDelay);
        }
        
        if (other.CompareTag("Customer") && _hasPackage)
        {
            Debug.Log("Package delivered!");
            _hasPackage = false;
            spriteRenderer.color = noPackageColor;
        }
    }
} 
