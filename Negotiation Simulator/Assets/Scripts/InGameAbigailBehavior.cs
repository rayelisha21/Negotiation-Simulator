using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class InGameAbigailBehavior : MonoBehaviour
{
    [SerializeField] float blink_interval = 8f;
    public Slider blink_slider;
    private SkinnedMeshRenderer skinMeshRenderer;
 
    float _time;
    
    void Start() {
        skinMeshRenderer = GetComponent<SkinnedMeshRenderer>();
        blink_slider = GameObject.Find("Blink").GetComponent<Slider>();
        _time = 0f;
    }
    
    void Update() {
        _time += Time.deltaTime;
        while(_time >= blink_interval) {
        BlinkFunction();
        _time -= blink_interval;
        }
    }
    
    void BlinkFunction() {
    }
    
}