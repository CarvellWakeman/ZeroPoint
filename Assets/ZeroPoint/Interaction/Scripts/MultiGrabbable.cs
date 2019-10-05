using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Valve.VR;
using Valve.VR.InteractionSystem;

public class MultiGrabbable : MonoBehaviour
{
    public SteamVR_Action PrimaryGrabAction;
    public Interactable PrimaryGrip;
    public Interactable SecondaryGrip;

    // Start is called before the first frame update
    void Start()
    {
        if (PrimaryGrip != null) {
            PrimaryGrip.onAttachedToHand += PrimaryGripGrabbed;
        }
        if (SecondaryGrip != null) {
            SecondaryGrip.onAttachedToHand += SecondaryGripGrabbed;
        }
    }

    // Update is called once per frame
    void Update()
    {
    }

    public void PrimaryGripGrabbed(Hand hand)
    {
        SetColor(Color.blue);
    }

    public void SecondaryGripGrabbed(Hand hand)
    {
        SetColor(Color.red);
    }

    void SetColor(Color color)
    {
       var renderer = gameObject.GetComponent<Renderer>();
       renderer.material.SetColor("_Color", color);
    }

}
