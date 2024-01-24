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


    public void Awake()
    {

        if(Instance!=null)
        {
            Destroy(this.gameObject);
            return;
        }
        Instance = this;
        DontDestroyOnLoad(gameObject);
    }


    public bool IsGameWon()
    {
        if (Instance.itemCount == Instance.itemList.Count)
        {
            return true;
        }
        return false;
    }

    public void PlayAudio()
    {
        if(Instance.IsGameWon())
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
