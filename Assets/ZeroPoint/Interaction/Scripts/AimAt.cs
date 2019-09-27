using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Valve.VR.InteractionSystem;

public class AimAt : MonoBehaviour
{
    public Transform Target;
    private bool DoAim = false;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // if (point1Attached && point2Attached)
        // {
            if (DoAim)
            {
                transform.LookAt(Target.transform);
            }
        // }
    }

    public void TargetAttached() {
        DoAim = true;
    }

    public void TargetDetached() {
        DoAim = false;
    }
}
