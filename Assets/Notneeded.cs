using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Individual : MonoBehaviour
{
    public Vector2 target;
    public float yposition;
    public float speed = 1.0f;
    public bool shouldmove = true;
    // Start is called before the first frame update
    void Start()
    {
        target = transform.position;
        yposition = yposition = transform.position.y;
    }

    // Update is called once per frame
    void Update()
    {
        if(shouldmove){
            float step = speed * Time.deltaTime;
            target = new Vector2(transform.position.x, yposition);
            transform.position = Vector2.Lerp(transform.position, target, step);


            if (Input.GetKey(KeyCode.W) && yposition < 3){
                Debug.Log(target);
                yposition += speed * Time.deltaTime;
            }

            if (Input.GetKey(KeyCode.S)&& yposition > -3)
            {
                Debug.Log("S was pressed");
                Debug.Log(target);
                yposition -= speed * Time.deltaTime;
            }

            }
            if (yposition < -3 || yposition > 3){
                shouldmove = false; 
            }
            else{
                shouldmove = true;
            }
        
    }}

