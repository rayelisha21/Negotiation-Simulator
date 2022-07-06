using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameOverSequence : MonoBehaviour
{
    public WordCollector wc;
    public Player player;
    public GameObject GoodEnd;
    public GameObject BadEnd;
    private bool success;

    // Start is called before the first frame update
    void Start()
    {
        success = false;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void End() {
        int points = player.totalpoints;
            if (points > 25) {
                success = true;
                //make the good end visible
                GoodEnd.transform.Translate(0, -2, 0);
            }
            else {
                //make the bad end visible
                BadEnd.transform.Translate(0, -2, 0);
            }
    }

}
