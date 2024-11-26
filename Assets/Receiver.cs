using UnityEngine;

public class Receiver : MonoBehaviour
{
    long receiverTime = 0;

    void Start()
    {
        
    }

    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        //���ù��� ������ �ð� ����ȭ �Ϸ�
        receiverTime = Time.GetTime();

        string satName = collision.GetComponent<SatelliteSignal>().satelliteName;
        float satPosX = collision.GetComponent<SatelliteSignal>().satellitePosX;
        float satPosY = collision.GetComponent<SatelliteSignal>().satellitePosY;
        long satTime = collision.GetComponent<SatelliteSignal>().time;

        Debug.Log(satName + " " + (receiverTime - satTime));
    }
}
