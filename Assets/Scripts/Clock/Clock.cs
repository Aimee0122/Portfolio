using System.Collections;
using System;
using UnityEngine;

public class Clock : MonoBehaviour
{
    [SerializeField]
    GameObject SecondsHand;

    [SerializeField]
    GameObject MinutesHand;

    [SerializeField]
    GameObject HoursHand;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        DateTime currentTime= DateTime.Now;

        float secondsDegree= -(currentTime.Second / 60f)* 360f;
        SecondsHand.transform.localRotation = Quaternion.Euler (new Vector3(0,0,secondsDegree));

        float minutesDegree= -(currentTime.Minute / 60f)* 360f;
        MinutesHand.transform.localRotation = Quaternion.Euler (new Vector3(0,0,minutesDegree));

        float hoursDegree= -(currentTime.Hour / 12f)* 360f;
        HoursHand.transform.localRotation = Quaternion.Euler (new Vector3(0,0,hoursDegree));

    }
}
