using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KingOfTheWorld : MonoBehaviour
{
    public static KingOfTheWorld CurrentKing { private set; get; }

    public int Kills;


    private void Awake()
    {
        if (CurrentKing == null)
        {
            Debug.Log("Actual king: "+ CurrentKing);

            Debug.Log("NOW WE HAVE A KING!!!");
            
            // This is a reference to actual instance of the class
            CurrentKing = this;

            Debug.Log(this);
            Debug.Log("Name of the king: " + this.name);
            Debug.Log("Kills of the king: " + this.Kills);

            DontDestroyOnLoad(gameObject);
        }
        else 
        {
            // When going to a scene where the game object is already located on
            // Destroy the duplicated game object (kill the fake king)
            Destroy(gameObject);

            Debug.Log("Usurper Killed! AQUI NÃO NENEM!");

            // Kills from duplicated king
            Debug.Log("Kills of the duplicated king (duplicated instace of KingOfTheWorld): " + this.Kills);

            // Kills from real king (static one)
            Debug.Log("Kills of the real king (static variable from singleton gameObject: CurrentKing): " + CurrentKing.Kills);
        }
    }
}
