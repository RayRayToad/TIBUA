using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using UnityEngine;
using UnityEngine.InputSystem;

public class AnimateHandOnInput : MonoBehaviour
{
    // Links Animation to Hand Input
    public InputActionProperty pinchAnimationAction;
    public InputActionProperty gripAnimationAction;
    public Animator handAninmator;


    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float triggervalue = pinchAnimationAction.action.ReadValue<float>();
        handAninmator.SetFloat("Trigger", triggervalue);
        //Debug.Log(triggervalue);

        float gripvalue = gripAnimationAction.action.ReadValue<float>();
        handAninmator.SetFloat("Grip", gripvalue);
        //Debug.Log(gripvalue);

        //Debug.Log --> Use only for debug purposes
    }
}
