using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class PaddleController : MonoBehaviour
{
    // Start is called before the first frame update
    public float speed;
    public Rigidbody2D rbright;
    public Rigidbody2D rbleft;
    //public Rigidbody2D rbball;
    public Vector2 TargetVelocityleft;
    public Vector2 TargetVelocityright;
    public GameObject leftSquare;
    public GameObject rightSquare;
    public GameObject ball;
    void Start()
    {
        leftSquare = Resources.Load<GameObject>("RectanglePaddle");
        rightSquare = Resources.Load<GameObject>("RectanglePaddle");
        
        speed = 5;
        rbleft = leftSquare.GetComponent<Rigidbody2D>();
        rbright = rightSquare.GetComponent<Rigidbody2D>();


        TargetVelocityleft = new Vector2(0, 0);
        TargetVelocityright = new Vector2(0, 0);


    }

    // Update is called once per frame
    void Update()
    {
        float currentleftPositiony = leftSquare.transform.position.y;
        float currentrightPositiony = rightSquare.transform.position.y;
        //Left Player is Done
        if (Input.GetKey(KeyCode.W))
        {
            if (currentleftPositiony < 3){
              //  Debug.Log(currentleftPositiony);
                TargetVelocityleft = new Vector2(rbleft.velocity.x, speed);
            }
        }
        else if (Input.GetKey(KeyCode.S))
        {
            if (currentleftPositiony > -3){
           //     Debug.Log(currentleftPositiony);
                TargetVelocityleft = new Vector2(rbleft.velocity.x, -speed);
            }
        }
        
        else {
            TargetVelocityleft = Vector2.zero;
        }
        
        rbleft.velocity = Vector2.Lerp(rbleft.velocity, TargetVelocityleft, Time.deltaTime * speed);

        if((currentleftPositiony >= 3 && TargetVelocityleft.y > 0) || (currentleftPositiony <= -3 && TargetVelocityleft.y < 0))
        {
            rbleft.velocity = new Vector2(rbleft.velocity.x, 0);
        }
        

        //Right Player is Done
        if (Input.GetKey(KeyCode.UpArrow)) {
            if(currentrightPositiony < 3){
                TargetVelocityright = new Vector2(rbright.velocity.x, speed);
            }   
        }
        else if (Input.GetKey(KeyCode.DownArrow))
        {
            if(currentrightPositiony > -3){
                TargetVelocityright = new Vector2(rbright.velocity.x, -speed);
            }
        }
        else{
            TargetVelocityright = Vector2.zero;
        }
            rbright.velocity = Vector2.Lerp(rbright.velocity, TargetVelocityright, Time.deltaTime * speed);

        if((currentrightPositiony >= 3 && TargetVelocityright.y > 0) || (currentrightPositiony <= -3 && TargetVelocityright.y < 0))
        {
            rbright.velocity = new Vector2(rbright.velocity.x, 0);
        }
    }/*
    public void ballcode(){
        float directionofball = Random.Range(0, 2) <0.5f ?-1.0f:1.0f;
        float angleBall = Random.value < 0.5 ? Random.Range(-1.0f,-0.5f): Random.Range(0.5f,1.0f);
        
        Vector2 direction = new Vector2(directionofball, angleBall);
        ball.AddForce(direction * ballspeed);*/
    }




       
      
