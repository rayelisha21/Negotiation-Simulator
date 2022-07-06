using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class HealthBar : MonoBehaviour
{
    public Slider health_slider;
    public TMP_Text health_text;

    public void SetMaxHealth(int health)
    {
        health_slider.maxValue = health;
        health_slider.value = health;
    }

    public void SetHealth(int health)
    {
        health_slider.value = health;
        health_text.text = (health + "/" + health_slider.maxValue).ToString();
    }

}
