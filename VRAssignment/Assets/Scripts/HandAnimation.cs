using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class HandAnimation : MonoBehaviour
{

    [SerializeField] private InputActionReference gripReference;
    [SerializeField] private Animator handAnimator;
    [SerializeField] private InputActionReference triggerReference;
    // Update is called once per frame
    void Update()
    {
        float gripValue = gripReference.action.ReadValue<float>();
        handAnimator.SetFloat("Grip", gripValue);

        float triggerValue = triggerReference.action.ReadValue<float>();
        handAnimator.SetFloat("Trigger", triggerValue);
    }
}
