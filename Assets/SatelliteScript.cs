using System;
using System.Diagnostics;
using System.Threading;
using UnityEngine;

public class SatelliteScript : MonoBehaviour
{
    //long satelliteTime = 0; //현재시각 기준 총 ms
    public GameObject signal;

    void Start()
    {
        InvokeRepeating(nameof(InstantiateSginal), 1f, 1f); //전파 발신 주기
        //satelliteTime = Time.GetTime();
    }

    void Update()
    {
        //UnityEngine.Debug.Log(satelliteTime.ToString());
        //UnityEngine.Debug.Log(Time.GetTime().ToString() + "a");
        //UnityEngine.Debug.Log((satelliteTime - Time.GetTime()).ToString() + "aa");
    }

    void InstantiateSginal()
    {


        GameObject go = Instantiate(signal, gameObject.transform);

        go.GetComponent<SatelliteSignal>().satelliteName = gameObject.name;
        go.GetComponent<SatelliteSignal>().satellitePosX = gameObject.transform.position.x;
        go.GetComponent<SatelliteSignal>().satellitePosY = gameObject.transform.position.y;
        //모든 위성의 시간 동기화 완료
        go.GetComponent<SatelliteSignal>().time = Time.GetTime();
    }
}
