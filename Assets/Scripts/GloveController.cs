using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

public class GloveController : MonoBehaviour
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
        grip = OVRInput.Get(OVRInput.Axis1D.SecondaryHandTrigger);
    }
    void FixedUpdate()
    {
        OVRInput.FixedUpdate();
        grip = OVRInput.Get(OVRInput.Axis1D.SecondaryHandTrigger);
        controller.SetFloat("Grip", grip);
        print("" + OVRInput.GetConnectedControllers());
    }
    public void SetGrip(float ngrip)
    {
        grip = ngrip;
    }
        
    

    
}
