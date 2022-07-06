using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovePowerpoint : MonoBehaviour
{
    public Transform screen;
    public int currentslide;
    public static Material slide1;
    public static Material slide2;
    public static Material slide3;
    public static Material slide4;
    public static Material slide5;
    public Material[] slides = {slide1, slide2, slide3, slide4, slide5};

    public TimeBar timebar;
    public WordCollector wordcollector;

    // Start is called before the first frame update
    void Start()
    {
        // Material slide1 = Resources.Load("PowerpointPictures/slide 1 material", typeof(Material)) as Material;
        // Material slide2 = Resources.Load("PowerpointPictures/slide 2 material", typeof(Material)) as Material;
        // Material slide3 = Resources.Load("PowerpointPictures/slide 3 material", typeof(Material)) as Material;
        // Material slide4 = Resources.Load("PowerpointPictures/slide 4 material", typeof(Material)) as Material;
        // Material slide5 = Resources.Load("PowerpointPictures/slide 5 material", typeof(Material)) as Material;
        
        screen.GetComponent<Renderer>().material = slides[currentslide - 1];
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void SlideForward()
    {
        timebar.countdown = false;
        timebar.SetTime(180);

        if (currentslide == 5) {
            currentslide = 5;
        }
        else {
            currentslide += 1;
        }
        
        screen.GetComponent<Renderer>().material = slides[currentslide - 1];

        timebar.countdown = true;
        wordcollector.EmptyText();
    }

    public void SlideBackward()
    {
        if (currentslide == 1) {
            currentslide = 1;
        }
        else {
            currentslide -= 1;
        }
        
        screen.GetComponent<Renderer>().material = slides[currentslide - 1];
    }
}






