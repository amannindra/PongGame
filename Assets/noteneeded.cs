using System.Collections.Generic;
using UnityEngine;
using System.Collections;
using UnityEditor;
public class NewBehaviourScript : MonoBehaviour
{
    public GameObject leftSquare;
    public GameObject rightSquare;
    public GameObject ball;
    public float movementSpeed;
    public Vector2 destination;

    public float yposition;
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("Start");
        movementSpeed = 0.0001f;
        leftSquare = GameObject.Find("LeftSquare");
        rightSquare = GameObject.Find("RightSquare");
        yposition = 0;
        
        destination = new Vector2(-7,yposition);
    }

    // Update is called once per frame
    void Update()
    {
        //leftSquare.transform.position = new Vector2(-7,yposition); //WORKS
        destination = new Vector2(-7,yposition);
        leftSquare.transform.position = Vector2.Lerp(leftSquare.transform.position, destination, movementSpeed);




        /*if(-3.5f < leftSquare.transform.position.y && leftSquare.transform.position.y < 3.5f)
        {
            leftSquare.transform.position = new Vector3(leftSquare.transform.position.x, 0, 0);
        }*/ 
        if (Input.GetKey(KeyCode.W) && leftSquare.transform.position.y < 3){
            Debug.Log(leftSquare.transform.position);
            yposition +=1;
        }
       /* if (Input.GetKeyDown(KeyCode.W) && leftSquare.transform.position.y < 3.5f)
        {
            Debug.Log(leftSquare.transform.position);
            Vector3 newPosition = leftSquare.transform.position + new Vector3(leftSquare.transform.position.x, 0);
            leftSquare.transform.position = newPosition;
        }*/

        if (Input.GetKey(KeyCode.S))
        {
            Debug.Log("S was pressed");
            Debug.Log(leftSquare.transform.position);
            yposition -=1;
        }
        if (Input.GetKeyDown(KeyCode.UpArrow)) {
            Debug.Log("UpArrow was pressed");
        }
        if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            Debug.Log("DownArrow was pressed");
        }
    }
}
