using UnityEngine;

public class MovewithGravity : MonoBehaviour
{

    public Rigidbody rb;
    public float jumpForce = 5.0f;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //space키를 누르면 점프
        if (Input.GetKeyDown(KeyCode.Space))
        {
            
            rb.AddForce(Vector3.up *jumpForce, ForceMode.Impulse);
        }
    }
}
