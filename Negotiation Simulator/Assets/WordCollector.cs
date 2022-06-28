using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class WordCollector : MonoBehaviour
{
    private string text;
    public GameObject RecogLogger;
    public TMP_Text wordtext;
    private string lastword;
    
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
        }
    }
}