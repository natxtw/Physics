using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour
{
    public Vector3 BallAcceleration; //Known as A
    public Vector3 BallVelocity;     //Known as V
    public Vector3 BallForce;        //Known as F
    public Vector3 BallMomentum;     //Known as P

    public Vector3 P1; // p1 = m(v1 - v2)

    public float BallMass;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        BallAcceleration = BallForce / BallMass; // (A = F / M)
        BallForce = new Vector3(0, 0, 0); //resets the force to prevent constant moving
        BallVelocity += BallAcceleration * 1 / 50; //Sets the velocity as Acceleration multiplied by 1 then divided by 50
        BallMomentum = BallMass * BallVelocity; // (P = M * V), this is Calculating the mometum to make the ball lighter and quicker
        transform.position += BallVelocity * 1 / 40; //Moves the balls position based on the velocity
    }
}

//https://epdf.pub/queue/3d-graphics-for-game-programming.html
//https://www.cimt.org.uk/projects/mepres/step-up/sect4/index.htm