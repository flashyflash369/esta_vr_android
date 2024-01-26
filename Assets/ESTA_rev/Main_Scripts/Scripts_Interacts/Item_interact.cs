using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Item_interact : MonoBehaviour
{
    public string name;
    public ParticleSystem explosionEffect;
    public GameController gameController;
    

    public void CheckIfItem()
    { 
        foreach(string itemName in gameController.itemList)
        {
            if(name == itemName)
            {
                gameController.itemCount++;
                this.gameObject.SetActive(false);
                Instantiate(explosionEffect, this.transform.position, explosionEffect.transform.rotation);
                gameController.PlayAudio();

            }
        }



    }
}
