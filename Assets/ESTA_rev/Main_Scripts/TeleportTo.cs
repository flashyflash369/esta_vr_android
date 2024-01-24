using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TeleportTo : MonoBehaviour
{
    public GameObject destinationArea;
    public Transform player;

    public void TeleportationTo()
    {
        player.position = destinationArea.transform.position;
    }
    

}
