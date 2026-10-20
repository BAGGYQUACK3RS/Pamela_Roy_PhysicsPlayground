using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerControl : MonoBehaviour
{
    [SerializeField] HingeJoint2D leftFlipper, rightFlipper;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Keyboard.current.escapeKey.wasPressedThisFrame)
        {
            Application.Quit();
        }

        if (Keyboard.current.aKey.isPressed)
        {
            leftFlipper.useMotor = true;
        }
        else
        {
            leftFlipper.useMotor = false;
        }

        if (Keyboard.current.dKey.isPressed)
        {
            rightFlipper.useMotor = true;
        }
        else
        {
            rightFlipper.useMotor = false;
        }
    }


}