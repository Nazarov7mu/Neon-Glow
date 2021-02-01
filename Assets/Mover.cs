using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mover : MonoBehaviour
{
    private float speed = 0.5f;
    Vector3 pointA;
    Vector3 pointB;

    void Start()
    {
        pointA = transform.position;
        pointB = new Vector3(transform.position.x, transform.position.y+4, 0);
    }

    void Update()
    {
        //PingPong between 0 and 1
        float time = Mathf.PingPong(Time.time * speed, 1);
        transform.position = Vector3.Lerp(pointA, pointB, time);
    }
}