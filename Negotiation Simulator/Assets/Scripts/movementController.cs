using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movementController : MonoBehaviour
{
    public Transform target;
    public float speed;
    public bool shake;
    public bool sitting;
    // Start is called before the first frame update
    void Start()
    {
        shake = false;
        sitting = false;
        
    }

    // Update is called once per frame
    void Update()
    {
        if (shake == false && sitting == false){
            float step = speed * Time.deltaTime;
            transform.position = Vector3.MoveTowards(transform.position, target.position, step);
        }
        
    }
}
