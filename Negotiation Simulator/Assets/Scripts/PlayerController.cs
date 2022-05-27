using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerController : MonoBehaviour
{
    
    public Transform target;
    public float speed;

    void Start()
    {

    }

    void FixedUpdate()
    {
        Vector3 a = target.position;
        Vector3 b = target.position;
        target.position = Vector3.MoveTowards(a, b, speed);
    }

}
