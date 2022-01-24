using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class TriGlove_Controller : MonoBehaviour
{

     private TriGlove glove;


    private void Awake()
    {
        glove = this.GetComponentInChildren<TriGlove>();
    }


    public void OnGripPressHold(InputAction.CallbackContext context)
    {
        glove.UpdatePointer(context.performed);
    }

    public void OnTriggerPress()
    {
        glove.FireFingerBullet();
    }

}
