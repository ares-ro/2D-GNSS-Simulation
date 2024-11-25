using UnityEngine;

public class SatelliteSignal : MonoBehaviour
{
    public string satelliteName;
    public float satellitePosX;
    public float satellitePosY;
    public long time;

    void Start()
    {
        
    }

    void FixedUpdate()
    {
        float signalSpeed = 2f; //���ĵǴ� �ӵ�, ������ ����
        int signalRange = 300; //�ش� �������� ���� �� �Ҹ�, ������ ��ȣ ����

        gameObject.transform.localScale = new Vector2(gameObject.transform.localScale.x + signalSpeed, gameObject.transform.localScale.y + signalSpeed);

        if(gameObject.transform.localScale.x > signalRange)
        {
            Destroy(gameObject);
        }
    }
}
