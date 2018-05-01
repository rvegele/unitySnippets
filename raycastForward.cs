using UnityEngine;
using System.Collections;

public class raycastForward : MonoBehaviour { 

    void Update()
    {
        RaycastHit hit;
        float theDistance;

        //debug in editor
        Vector3 forward = transform.TransformDirection(Vector3.forward) * 10.0f;    
        Debug.DrawRay(transform.position, forward, Color.green);

        if(Physics.Raycast(transform.position,(forward), out hit)) {
            theDistance = hit.distance;
            print (theDistance + " " + hit.collider.gameObject.name);
        }
    }

}
