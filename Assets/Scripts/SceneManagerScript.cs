using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class SceneManagerScript : MonoBehaviour
{

    public Text KillsText;
    // Start is called before the first frame update
    void Start()
    {
        KillsText.text = "KILLS: " + KingOfTheWorld.CurrentKing.Kills.ToString();
    }

    public void OnToScene1Clicked()
    {
        SceneManager.LoadScene("Scene1");
        KingOfTheWorld.CurrentKing.Kills++;
    }

    public void OnToScene2Clicked()
    {
        SceneManager.LoadScene("Scene2");
    }
}
