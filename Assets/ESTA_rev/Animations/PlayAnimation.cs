using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayAnimation : MonoBehaviour
{

    public Animator controller;

    public void PlayDoorAnimation()
    {
        controller.SetTrigger("openTrigger");
    }
}
