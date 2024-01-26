using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class UI_Script : MonoBehaviour
{

    public List<ScriptableTeleport> teleportationArea = new List<ScriptableTeleport>();

    public List<Button> teleportButtons = new List<Button>();
    int currentButton = 0;

    public TextMeshProUGUI teleportationAreaText;


    public void Teleport()
    {
        //StartCoroutine(SceneTransitionTime());
        teleportationArea[currentButton].Teleport();

    }

    IEnumerator SceneTransitionTime()
    {
        yield return new WaitForSeconds(1f);
        teleportationArea[currentButton].Teleport();

    }

    public void GoToNextButton()
    {
        teleportButtons[currentButton].gameObject.SetActive(false);
        currentButton = (currentButton + 1) % teleportButtons.Count;
        teleportButtons[currentButton].gameObject.SetActive(true);
    }

    public void SetUIText()
    {
        teleportationAreaText.text = teleportationArea[currentButton].name;
    }


}
