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

    //fixedupdate �ֱ� 0.01�� ������
    void FixedUpdate()
    {
        float signalSpeed = 10f * 2f; //���ĵǴ� �ӵ�, ������ ���� (��������Ʈ ��ü�� Ŀ���Ƿ� ���� ���� �ӵ��� ���������� �����ؾ� �ϴ� /2 �ʿ�, �� 20�̸� ���� �ӵ��� 10)
        //fixedupdate �ֱ� * signalSpeed / 2 �� ���� ���� ���� �ӵ�. 10���ǵ�(���ļӵ�) / 0.01s(������Ʈ �ֱ�) => 1000���ǵ�(�ȼ�)/s 
        //���� �ľ��ϱ� ���ϰ� ����
        int signalRange = 3000; //�ش� �������� ���� �� �Ҹ�, ������ ��ȣ ����

        //��ȣ ��������Ʈ�� �°� �ݶ��̴� ����
        gameObject.GetComponent<CircleCollider2D>().radius = gameObject.GetComponent<RectTransform>().sizeDelta.x / 2;

        gameObject.GetComponent<RectTransform>().sizeDelta = new Vector2(
            gameObject.GetComponent<RectTransform>().sizeDelta.x + signalSpeed, 
            gameObject.GetComponent<RectTransform>().sizeDelta.y + signalSpeed);

        if(gameObject.GetComponent<RectTransform>().sizeDelta.x > signalRange)
        {
            Destroy(gameObject);
        }
    }
}
