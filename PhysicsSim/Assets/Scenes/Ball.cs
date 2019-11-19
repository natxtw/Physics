using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour
{
    public Vector3 BallAcceleration; //A
    public Vector3 BallVelocity;     //V
    public Vector3 BallForce;        //F
    public Vector3 BallMomentum;     //P

    public float BallMass;

    // Start is called before the first frame update
    void Start()
    {
        BallForce = new Vector3(1000,0,0);
    }

    // Update is called once per frame
    void Update()
    {
        BallAcceleration = BallForce / BallMass; // A = F / M
        BallForce = new Vector3(0, 0, 0); //resets the force to prevent constant moving
        BallVelocity += BallAcceleration * 1 / 50; //Sets the velocity as Acceleration multiplied by 1 then divided by 50
        BallMomentum = BallMass * BallVelocity; // P = M * V //Calculating the mometum to make the ball lighter and quicker
        transform.position += BallVelocity * 1 / 50; //Moves the balls position based on the velocity
    }
}

//https://epdf.pub/queue/3d-graphics-for-game-programming.html