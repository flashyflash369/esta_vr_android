using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Timer : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI timeText;
    private float timeElapsed;
    private int minutes;
    private int seconds;

    private void Update()
    {

        if(GameController.Instance.IsGameWon())
        {
            timeText.color = Color.green;
            return;
        }
        timeElapsed += Time.deltaTime;
        minutes = Mathf.FloorToInt(timeElapsed / 60);
        seconds = Mathf.FloorToInt(timeElapsed % 60);

        timeText.text = string.Format("{0:00} : {1:00}", minutes, seconds);

    }
}
