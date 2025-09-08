using UnityEngine;

public class ProPeller : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created

    private float RotationSpeed = 100f;
    void Start()

    {

    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(Vector3.forward * RotationSpeed * Time.deltaTime);
    }
}
