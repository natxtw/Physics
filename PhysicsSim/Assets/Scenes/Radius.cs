using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Radius : MonoBehaviour
{
    public Renderer ObjRender;
    public float ObjRadius;
    public Vector3 ObjCentrePoint;
    
    // Start is called before the first frame update
    void Start()
    {
        ObjRender = GetComponent<Renderer>(); //Grabs the renderer
    }

    private void OnDrawGizmosSelected() //draws around objects
    {
        ObjCentrePoint = ObjRender.bounds.center; //finds the center of the object
        ObjRadius = ObjRender.bounds.extents.magnitude / 2; //uses the mesh render to find the object bounds
        Gizmos.color = Color.green; //changes colour
        Gizmos.DrawWireSphere(ObjCentrePoint, ObjRadius); //draws the frame
    }
}
