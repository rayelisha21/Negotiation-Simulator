using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class WordCollector : MonoBehaviour
{
    private string text;
    private string lastword;
    public GameObject RecogLogger;
    public Player playerstats;
    public HealthBar healthbar;
    public GameObject PowerpointChanger;
    public TMP_Text wordtext;
    public TMP_Text pointtext;
    public GameOverSequence go;
    
    
    private bool pregame;
    private bool recap;
    private bool slideshow;
    private bool obj1;
    private bool obj2;
    public bool end;
    
    private string[] greetinglist = {"hi", "hello", "hey", "nice" , "great", "meet"};
    private string[] recaplist = {"increase profit", "profitability", "doesn't", 
    "does not", "offer enough", "provide", "have any", "healthy"};
    private string[] slide1list = {"slides", "slideshow", "questions"};
    private string[] slide2list = {"many", "a lot", "several", "options", "snacks",
    "customers", "increase availability", "labels", "diet", "dietary", "restrictions", 
    "small", "compact", "economic", "efficient", "clear", "packaging"};
    private string[] slide3list = {"revenue", "sales", "commission", "increase", 
    "payment plan", "gain customers", "new customers", "profitable"};
    private string[] slide4list = {"increase profit", "profitability", "healthy", 
    "retain", "gain", "small", "compact", "revenue", "money", "diet"};
    private string[] slide5list = {"thank you", "thanks", "listening", "appreciate", 
    "time", "questions"};
    private string[] obj1list = {"highest", "high", "up to", "500", "five hundred", 
    "month", "guests", "customes", "satisfied"};
    private string[] obj2list = {"feel", "felt", "found", "trial", "hospital", "popular", 
    "trending", "boost", "increase", "sales"};
    
    // Start is called before the first frame update
    void Start()
    {
        pregame = true;
        recap = false;
        slideshow = false;
        obj1 = false;
        obj2 = false;
    }

    // Update is called once per frame
    void Update()
    {
        RecognitionLogger rl = RecogLogger.GetComponent<RecognitionLogger>();
        if (rl.ended && !string.Equals(lastword, rl.totaltext)) {
            lastword = rl.totaltext;
            text += rl.totaltext + " ";
            wordtext.text = text;
            
            // find the place the game is currently at
            // call the word method with the corresponding list
            if (pregame)
                CheckWords(greetinglist);
            else if (recap)
                CheckWords(recaplist);
            else if (slideshow){
                int slide = PowerpointChanger.GetComponent<MovePowerpoint>().currentslide;
                if (slide == 1)
                    CheckWords(slide1list);
                else if (slide == 2)
                    CheckWords(slide2list);
                else if (slide == 3)
                    CheckWords(slide3list);
                else if (slide == 4)
                    CheckWords(slide4list);
                else
                    CheckWords(slide5list);
            }
            else if (obj1)
                CheckWords(obj1list);
            else if (obj2)
                CheckWords(obj2list);
            
        } 
    }

    void AdjustPoints(int value)
    {
        playerstats.currentHealth += value;
        playerstats.totalpoints += value;
        pointtext.text = playerstats.currentHealth.ToString();
        healthbar.SetHealth(playerstats.currentHealth);
    }

    void CheckWords(string[] list)
    {
        foreach (var word in list) {
		    if (lastword.Contains(word.ToString()))
			    AdjustPoints(1);
	    }
        if (lastword.Contains("um"))
            AdjustPoints(-1);
        if (lastword.Contains("uh"))
            AdjustPoints(-1);
    }

    public void ChangeState() {
        if (pregame == true){
            pregame = false;
            recap = true;
        }
        else if (recap == true){
            recap = false;
            slideshow = true;
        }
        else if (slideshow == true){
            slideshow = false;
            obj1 = true;
        }
        else if (obj1 == true){
            obj1 = false;
            obj2 = true;
        }
        else {
            obj2 = false;
            end = true;
            go.End();
        }
    }

    public void EmptyText() {
        text = "";
    }
    
    // void StartRecap(){
    //     pregame = false;
    //     recap = true;
    // }

    // void StartSlideshow(){
    //     recap = false;
    //     slideshow = true;
    // }

    // void StartObj1(){
    //     slideshow = false;
    //     obj1 = true;
    // }

    // void StartObj2(){
    //     obj1 = false;
    //     obj2 = true;
    // }

}