using System;
using System.Diagnostics;
using System.Threading;
using UnityEngine;

public class SatelliteScript : MonoBehaviour
{
    //long satelliteTime = 0; //����ð� ���� �� ms
    public GameObject signal;

    void Start()
    {
        InvokeRepeating(nameof(InstantiateSginal), 1f, 1f); //���� �߽� �ֱ�
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
        //��� ������ �ð� ����ȭ �Ϸ�
        go.GetComponent<SatelliteSignal>().time = Time.GetTime();
    }
}
