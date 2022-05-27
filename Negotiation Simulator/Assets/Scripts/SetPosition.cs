using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SetPosition : MonoBehaviour
{
    
    void Start()
    {
        StartCoroutine(RePositionWithDelay());
    }

    IEnumerator RePositionWithDelay()
    {
            FirstPosition();
            yield return new WaitForSeconds(20f);
            SecondPosition();
    }

    void FirstPosition()
    {
        transform.position = new Vector3(0.443f, 0.0f, 1.722f);
    }

    void SecondPosition()
    {
        transform.position = new Vector3(-2.55f, 0.0f, 0.46f);
    }
}
