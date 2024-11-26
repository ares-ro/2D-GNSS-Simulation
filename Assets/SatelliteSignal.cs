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

    //fixedupdate 주기 0.01로 변경함
    void FixedUpdate()
    {
        float signalSpeed = 10f * 2f; //전파되는 속도, 현실의 광속 (스프라이트 자체가 커지므로 실제 전파 속도는 반지름으로 간주해야 하니 /2 필요, 즉 20이면 전파 속도는 10)
        //fixedupdate 주기 * signalSpeed / 2 한 값이 실제 전파 속도. 10스피드(전파속도) / 0.01s(업데이트 주기) => 1000스피드(픽셀)/s 
        //추후 파악하기 편하게 정리
        int signalRange = 3000; //해당 범위까지 진행 후 소멸, 현실의 신호 강도

        //신호 스프라이트랑 맞게 콜라이더 조정
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
