using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class GameController : MonoBehaviour
{

    public static GameController Instance;
    public List<string> itemList = new List<string>();
    [SerializeField] private TextMeshProUGUI winText;
    [SerializeField] public int itemCount = 0;

    public AudioSource coinAudio;
    public AudioSource winAudio;

    public bool IsGameWon()
    {
        if (itemCount == itemList.Count)
        {
            return true;
        }
        return false;
    }

    public void PlayAudio()
    {
        if(IsGameWon())
        {
            winAudio.Play();
            winText.gameObject.SetActive(true);

        }
        else
        {
            coinAudio.Play();
        }
    }
}
