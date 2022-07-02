using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class WordCollector : MonoBehaviour
{
    private string text;
    public GameObject RecogLogger;
    public Player playerstats;
    public HealthBar healthbar;
    public TMP_Text wordtext;
    public TMP_Text pointtext;
    private string lastword;
    private string[] list1 = {"great price", "fast", "small"};

    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        RecognitionLogger rl = RecogLogger.GetComponent<RecognitionLogger>();
        if (rl.ended && !string.Equals(lastword, rl.totaltext)) {
            lastword = rl.totaltext;
            text += rl.totaltext + " ";
            wordtext.text = text;
            foreach (var word in list1) {
		        if (lastword.Contains(word.ToString()))
			        AdjustPoints(1);
	        }
            if (lastword.Contains("um"))
                AdjustPoints(-1);
            if (lastword.Contains("uh"))
                AdjustPoints(-1);
        } 
    }

    void AdjustPoints(int value)
    {
        playerstats.currentHealth += value;
        pointtext.text = playerstats.currentHealth.ToString();
        healthbar.SetHealth(playerstats.currentHealth);
    }
}