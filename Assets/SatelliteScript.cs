using System;
using UnityEngine;

public class SatelliteScript : MonoBehaviour
{
    long totalTimeMilliseconds;

    public GameObject signal;

    void Start()
    {
        InvokeRepeating("InstantiateSginal", 1f, 1f); //발신 주기
    }

    void Update()
    {

    }

    void InstantiateSginal()
    {
        GameObject go = Instantiate(signal, gameObject.transform);
        go.GetComponent<SatelliteSignal>().satellitePosX = gameObject.transform.position.x;
        go.GetComponent<SatelliteSignal>().satellitePosY = gameObject.transform.position.y;
        //go.GetComponent<Transform>().set;
    }
}
