using UnityEngine;

public class FollwingControl : MonoBehaviour
{
    public GameObject Follwing;
    private Vector3 offset = new Vector3(0.304806709f, 8.24342346f, -13.2731934f);
    void Start()
    {
        
    }

    
    void LateUpdate()
    {
        transform.position = Follwing.transform.position + offset;

    }
}
