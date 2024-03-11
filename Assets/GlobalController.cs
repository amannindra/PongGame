using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GlobalController : MonoBehaviour
{
    public ballClass classBall;
    public GameObject Field;
    public GameObject leftSquareBox;
    public GameObject rightSquareBox;

    public GlobalController game;

    // Start is called before the first frame update
    void Start()
    {
    
        Field = Resources.Load<GameObject>("Field");
        leftSquareBox = Resources.Load<GameObject>("LeftSquare");
        rightSquareBox = Resources.Load<GameObject>("RightSquare");
    }

    // Update is called once per frame
    void Update()
    {
        //It needs to check for collisions between ball and wall
        //Its need to create the beginning

    }


}
