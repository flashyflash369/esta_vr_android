using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class TeleportToHome : MonoBehaviour
{
    public Transform playerTransform;
    public InputActionReference teleportAction;

    private void Awake()
    {
        teleportAction.action.started += TeleportBack;
    }

    private void OnDestroy()
    {
        teleportAction.action.canceled -= TeleportBack;
    }

    public void TeleportBack(InputAction.CallbackContext context)
    {
        playerTransform.position = this.transform.position;
    }
}
