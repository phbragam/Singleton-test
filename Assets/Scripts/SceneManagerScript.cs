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
        KillsText.text = "REAL KING KILLS: " + KingOfTheWorld.CurrentKing.Kills.ToString();
    }

    void Update()
    {
        KillsText.text = "REAL KING KILLS: " + KingOfTheWorld.CurrentKing.Kills.ToString();
    }

    public void OnToScene1Clicked()
    {
        SceneManager.LoadScene("Scene1");
        Debug.Log("The only real King Of The World is back to Denmark!");
        
    }

    public void OnToScene2Clicked()
    {
        SceneManager.LoadScene("Scene2");
        Debug.Log("The only real King Of The World went to Vinland!");
        
    }
}
