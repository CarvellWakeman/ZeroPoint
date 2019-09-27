using System.Collections;
using System.Collections.Generic;
using UnityEngine;
// using Valve.VR.InteractionSystem;

public class MultiGrabbable : MonoBehaviour
{
    public Transform[] GrabPoints;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //find the vector pointing from our position to the target
        var dir = (GrabPoints[0].position - transform.position).normalized;

        //create the rotation to look at the target
        transform.rotation = Quaternion.LookRotation(dir);
    }

}
