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
    void Update()
    {
        if (Input.GetKeyDown("e"))
        {
            BallScript.BallForce = new Vector3(1000, 0, 0);
            Debug.Log("I worked");
        }
    }
}
