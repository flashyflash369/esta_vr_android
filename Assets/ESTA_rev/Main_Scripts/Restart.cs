using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.SceneManagement;


public class Restart : MonoBehaviour
{
    public InputActionReference restartAction;

    private void Awake()
    {
        restartAction.action.started += RestartApp;
    }

    private void OnDestroy()
    {
        restartAction.action.canceled -= RestartApp;
    }

    public void RestartApp(InputAction.CallbackContext value)
    {
        SceneManager.LoadScene(0);
    }
}
