using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GloveLController : MonoBehaviour
{
    public Animator controller;
    [Range(0,1)]
    public float grip;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
     void Update()
    {
        OVRInput.Update();
        grip = OVRInput.Get(OVRInput.Axis1D.PrimaryHandTrigger);
    }
    void FixedUpdate()
    {
        OVRInput.FixedUpdate();
        grip = OVRInput.Get(OVRInput.Axis1D.PrimaryHandTrigger);
        controller.SetFloat("Grip", grip);
        print("" + OVRInput.GetConnectedControllers());
    }
}
