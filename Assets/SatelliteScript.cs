using System;
using UnityEngine;

public class SatelliteScript : MonoBehaviour
{
    long totalTimeMilliseconds;

    public GameObject signal;

    void Start()
    {
        InvokeRepeating(nameof(InstantiateSginal), 1f, 1f); //발신 주기
    }

    void Update()
    {

    }

    void InstantiateSginal()
    {
        GameObject go = Instantiate(signal, gameObject.transform);

        go.GetComponent<SatelliteSignal>().satelliteName = "sat1";
        go.GetComponent<SatelliteSignal>().satellitePosX = gameObject.transform.position.x;
        go.GetComponent<SatelliteSignal>().satellitePosY = gameObject.transform.position.y;
        //전역 만들고 받아오기? 아니면 그냥 datetime.now?
        //go.GetComponent<SatelliteSignal>().time = 0;
    }
}
