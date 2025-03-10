using UnityEngine;

public class VectorStudy : MonoBehaviour
{
    /*public Vector2 v2 = new Vector2(10, 10);
    public Vector3 v3 = new Vector3(10, 10, 10); 
    public Vector4 v4 = new Vector4(10, 10, 10, 10);*/





    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Vector3 a = new Vector3(1, 1, 0);
        Vector3 b = new Vector3(2, 0, 0);

        Vector3 c = a + b;
        Debug.Log("Vector :" + c);
        Debug.Log("Length :" + c.magnitude);
        Debug.Log("Normalize :" + c.normalized);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
