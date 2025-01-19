using UnityEngine;

public class FollowCamera : MonoBehaviour
{
    [SerializeField] GameObject driver;
    private readonly int _cameraOffset = 10;
    void LateUpdate()
    {
        transform.position = driver.transform.position + new Vector3(0,0, -_cameraOffset);
    }
}
