using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Activeness : MonoBehaviour
{
    private bool isActive = false;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    public void SetActiveness()
    {
        isActive = !isActive;
        this.gameObject.SetActive(isActive);
    }
}
