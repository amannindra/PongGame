using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEditor.Experimental.GraphView;
using UnityEngine;

public class ballClass : MonoBehaviour
{
    public Rigidbody rb;
    public float ballspeed;
    public float maxSpeed;
    public GameObject theBallObject;

    public void startFunction()
    {
        theBallObject = GameObject.Find("CirclePre(Clone)");


        rb = GetComponent<Rigidbody>();
    }

    public void resetBall()
    {
        rb.velocity = Vector2.zero;


         
    }
    public bool randomChoice()
    {
        return Random.Range(0, 2) == 1;
    }
    public void beginBall()
    {
        resetBall();

    }


}
