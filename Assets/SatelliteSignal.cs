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
        float signalSpeed = 2f; //전파되는 속도, 현실의 광속
        int signalRange = 300; //해당 범위까지 진행 후 소멸, 현실의 신호 강도

        gameObject.transform.localScale = new Vector2(gameObject.transform.localScale.x + signalSpeed, gameObject.transform.localScale.y + signalSpeed);

        if(gameObject.transform.localScale.x > signalRange)
        {
            Destroy(gameObject);
        }
    }
}
