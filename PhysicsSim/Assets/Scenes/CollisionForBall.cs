using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollisionForBall : MonoBehaviour
{
    public GameObject Ball1;
    public GameObject Ball2;
    
    // Start is called before the first frame update
    void Start()
    {
        //finds the gameobjects with the specific tag
        Ball1 = GameObject.Find("Ball1"); 
        Ball2 = GameObject.Find("Ball2");
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        float distance = Vector3.Distance(Ball1.transform.position, Ball2.transform.position);//calculates distance between the two balls
        if (distance < Ball1.GetComponent<Radius>().ObjRadius + Ball2.GetComponent<Radius>().ObjRadius) //Grabs the radius script for each ball and their radius
        {
            Debug.Log("The Balls Are Colliding"); //Colider message
        }
        Debug.Log(Ball1.transform.position); //Displays the ball1's current position
    }
}
