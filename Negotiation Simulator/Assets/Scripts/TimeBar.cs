using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class TimeBar : MonoBehaviour
{
    public Slider time_slider;
    public Player player;
    public TMP_Text timeText;

    public float time_remaining;
    public bool countdown;

    public void SetMaxTime(int time)
    {
        time_slider.maxValue = time;
        time_slider.value = time;
        time_remaining = time;
        DisplayTime(time);
    }

    public void SetTime(int time)
    {
        SetMaxTime(time);
    }

    void Update()
    {
        if (countdown)
        {
            if (time_remaining > 0)
            {
                time_remaining -= Time.deltaTime;
                time_slider.value = time_remaining;
                DisplayTime(time_remaining);
            }
            else
            {
                time_remaining = 0;
                time_slider.value = time_remaining;
                countdown = false;
                DisplayTime(0);
            }
        }
    }

    void DisplayTime(float timeToDisplay)
    {
        float minutes = Mathf.FloorToInt(timeToDisplay / 60);  
        float seconds = Mathf.FloorToInt(timeToDisplay % 60);
        timeText.text = string.Format("{0:00}:{1:00}", minutes, seconds);
    }


}
