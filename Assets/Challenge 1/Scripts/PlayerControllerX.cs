using UnityEngine;

public class ArcadePlaneController : MonoBehaviour
{
    private float moveSpeed = 10f;   // Slower forward speed
    public float pitchSpeed = 60f;  // Nose up/down speed
    public float yawSpeed = 50f;    // Turn left/right speed
    public float rollSpeed = 80f;   // Tilt left/right speed

    void Update()
    {
        // Always move forward at constant speed
        transform.Translate(Vector3.forward * moveSpeed * Time.deltaTime);

        // Pitch (Up = nose down, Down = nose up)
        float pitch = 0f;
        if (Input.GetKey(KeyCode.UpArrow)) pitch = -pitchSpeed * Time.deltaTime;
        if (Input.GetKey(KeyCode.DownArrow)) pitch = pitchSpeed * Time.deltaTime;

        // Yaw (A/D keys) - turn left/right
        float yaw = 0f;
        if (Input.GetKey(KeyCode.A)) yaw = -yawSpeed * Time.deltaTime;
        if (Input.GetKey(KeyCode.D)) yaw = yawSpeed * Time.deltaTime;

        // Roll (Q/E keys) - tilt left/right
        float roll = 0f;
        if (Input.GetKey(KeyCode.Q)) roll = rollSpeed * Time.deltaTime;
        if (Input.GetKey(KeyCode.E)) roll = -rollSpeed * Time.deltaTime;

        // Apply rotation
        transform.Rotate(pitch, yaw, roll);
    }
}
