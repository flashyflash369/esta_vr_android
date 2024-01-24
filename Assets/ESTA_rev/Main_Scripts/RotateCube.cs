using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateCube : MonoBehaviour
{
    public float speed = 1f;
    // Start is called before the first frame updatepdate is called once per frame
    void Update()
    {
        this.transform.Rotate(speed, speed, speed);
    }
}
