using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TimeBar : MonoBehaviour
{
    public Slider time_slider;
    public Player player;

    public float time_remaining;
    public bool countdown = true;

    public void SetMaxTime(int time)
    {
        time_slider.maxValue = time;
        time_slider.value = time;
        time_remaining = time;
    }

    public void SetTime(int time)
    {
        time_slider.value = time;
        time_remaining = time;
    }

    void Update()
    {
        if (countdown)
        {
            if (time_remaining > 0)
            {
                time_remaining -= Time.deltaTime;
                time_slider.value = time_remaining;
            }
            else
            {
                countdown = false;
            }
        }
    }
}
