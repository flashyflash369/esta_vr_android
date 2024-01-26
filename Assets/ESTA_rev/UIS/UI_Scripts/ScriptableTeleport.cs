using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;


[CreateAssetMenu(menuName="ScriptableObjects/Teleport")]
public class ScriptableTeleport : ScriptableObject
{
    public string name;
    public int teleportationAreaId;

    public void Teleport()
    {
        SceneManager.LoadScene(teleportationAreaId);
    }


}
