using UnityEngine;

public class MonoBehaviorExample : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Debug.Log("Start: ������ ���۵� �� ȣ��˴ϴ�.");
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log("Update: �����Ӹ��� ȣ��˴ϴ�.");
    }

    private void FixedUpdate()
    {
        Debug.Log("Fixedupdate: ���� ���꿡 ���˴ϴ�.");
    }

    //ctrl shift m
}
