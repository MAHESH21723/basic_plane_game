using UnityEngine;

public class PlayerControl : MonoBehaviour
{
    private float Speed = 20f;
    private float TurnSpeed=10f;
    private float horizontalInput;
    private float verticalInput;
    void Start()
    {
        
    }

   
    void Update()
    {
        horizontalInput = Input.GetAxis("Horizontal");
        verticalInput = Input.GetAxis("Vertical");
        transform.Translate(Vector3.forward * Time.deltaTime * Speed * verticalInput);
        transform.Rotate(Vector3.up, Time.deltaTime * TurnSpeed * horizontalInput);
    }
}
