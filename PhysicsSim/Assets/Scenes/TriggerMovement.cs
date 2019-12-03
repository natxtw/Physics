using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerMovement : MonoBehaviour
{
    private Ball BallScript;

    // Start is called before the first frame update
    void Start()
    {
        BallScript = GetComponent <Ball>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if (Input.GetKeyDown("e"))
        {
            BallScript.AddForce = new Vector3(10, 0, 0);
            Debug.Log("I worked");
        }
    }
}
