using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class Countdown : MonoBehaviour
{

    float currentTime = 0f;
    float startingTime = 10f;

    [SerializeField] Text countdownTimer;

    void Start()
    {
        currentTime = startingTime;
    }

    void Update()
    {
        currentTime -= 1 * Time.deltaTime;
        countdownTimer.text = currentTime.ToString("0");
       
        if(currentTime <= 0)
        {
            currentTime = 0;
        }
    }

}
