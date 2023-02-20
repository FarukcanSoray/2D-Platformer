using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerInputHandler : MonoBehaviour
{
    public Vector2 rawMovementInput { get; private set; }
    public int normInputX { get; private set; }
    public int normInputY { get; private set; }
    public void OnMoveInput(InputAction.CallbackContext context)
    {
        rawMovementInput = context.ReadValue<Vector2>();

        normInputX = (int)(rawMovementInput * Vector2.right).normalized.x;
        normInputY = (int)(rawMovementInput * Vector2.up).normalized.y;
    }

    public void OnJumpInput(InputAction.CallbackContext context)
    {


    }
}
