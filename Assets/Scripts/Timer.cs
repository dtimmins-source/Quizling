using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Timer : MonoBehaviour
{
    [SerializeField] float timeToCompleteQuestion = 30f;
    [SerializeField] float timeToShowCorrectAnswer = 10f;

    public bool isAnsweringQuestion = false;
    
    float timerValue;
    
    void Update()
    {
        UpdateTimer();
    }

    void UpdateTimer()
    {
        timerValue -= Time.deltaTime;

        if(timerValue <= 0)
        {
            if(isAnsweringQuestion == true)
            {
                isAnsweringQuestion = false;
                timerValue = timeToShowCorrectAnswer;
            }
            else 
            {
                isAnsweringQuestion = true;
                timerValue = timeToCompleteQuestion;
            }
        }

        Debug.Log(timerValue);
    }
}
