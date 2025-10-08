using UnityEngine;

public class EarthRotation : MonoBehaviour
{
    public float rotationSpeed = 30f; 
    void Update()
    {
        transform.Rotate(Vector3.up, rotationSpeed * Time.deltaTime);
    }
}

