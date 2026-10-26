using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerControl : MonoBehaviour
{
    [SerializeField] HingeJoint2D leftFlipper, rightFlipper;
    public bool isLaunched, flippersActive;
    [SerializeField] BallController ballControl;

    void Update()
    {
        if (Keyboard.current.sKey.isPressed && !flippersActive)
        {
            flippersActive = true;
            ballControl.ReactivateBall();
        }

        if (Keyboard.current.escapeKey.wasPressedThisFrame)
        {
            Application.Quit();
        }

        if (Keyboard.current.aKey.isPressed && flippersActive)
        {
            leftFlipper.useMotor = true;
        }
        else
        {
            leftFlipper.useMotor = false;
        }

        if (Keyboard.current.dKey.isPressed && flippersActive)
        {
            rightFlipper.useMotor = true;
        }
        else
        {
            rightFlipper.useMotor = false;
        }
    }
}