using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollisionForBall : MonoBehaviour
{
    public GameObject Ball1;
    public GameObject Ball2;

    private Ball BallScript;

    Vector3 Impulse;

    // Start is called before the first frame update
    void Start()
    {
        //finds the gameobjects with the specific tag
        Ball1 = GameObject.Find("Ball1"); 
        Ball2 = GameObject.Find("Ball2");

        BallScript = GetComponent<Ball>(); //Gets the script
    }

    // Update is called once per frame
    void FixedUpdate() //FixedUpdate() can run more frequent runs and is more suitable for physics over the standard Update()
    {
        Colliding();
    }

    void Colliding()
    {
        float distance = Vector3.Distance(Ball1.transform.position, Ball2.transform.position);//calculates distance between the two balls
        if (distance < Ball1.GetComponent<Radius>().ObjRadius + Ball2.GetComponent<Radius>().ObjRadius) //Grabs the radius script for each ball and their radius
        {
            Debug.Log("The Balls Are Colliding"); //Colider message
            ImpulseCalc(Ball1.GetComponent<Ball>().BallMass, Ball1.GetComponent<Ball>().Direction);
            Ball1.GetComponent<Ball>().ImpulseCol(Impulse);
            Ball2.GetComponent<Ball>().ImpulseCol(-Impulse);
        }
        //Debug.Log(Ball1.transform.position); //Displays the ball1's current position

        
    }

    void ImpulseCalc(float _mass, Vector3 _Direction)
    {
        Vector3 VelocityTemp = Vector3.Dot(Ball1.GetComponent<Ball>().BallVelocity, _Direction) * _Direction;
        Impulse = -VelocityTemp * (1 + 1) * ((Ball2.GetComponent<Ball>().BallMass * _mass) / (Ball2.GetComponent<Ball>().BallMass + _mass)); //P1 = Ball 1 Mass * (Ball 1 Velocity after - Ball 1 BallVelocity) = -Ball 2 Mass (Ball 2 velocity after - Ball 2 velocity) 


    }

}
