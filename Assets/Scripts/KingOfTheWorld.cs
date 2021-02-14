using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KingOfTheWorld : MonoBehaviour
{
    public static KingOfTheWorld CurrentKing { private set; get; }

    public int Kills;

    float timeToPrintKills = 3f;


    private void Awake()
    {
        if (CurrentKing == null)
        {
            Debug.Log("Actual king: " + CurrentKing + "There is no king!");

            Debug.Log("Now we have a king!!!");

            // This is a reference to actual instance of the class.
            // To the object executing a member function.
            CurrentKing = this;

            // Components share the same "name" with the game object and all attached components.
            // It inherits "name" fild from MonoBehaviour.
            Debug.Log("Name of the king: " + name);
            Debug.Log("Kills of the king: " + Kills);

            DontDestroyOnLoad(gameObject);
        }
        else
        {
            // When going to a scene where the game object (KingOfTheWorld) is already located on.
            // Destroy the duplicated game object (kill the fake king). 
            // The game object destroyed is the one that is already in the scene.
            // The timer (5f) is to be able to see that the king destroyed is the one  
            // that is already in the scene.
            // If the timer is smaller then TimeToPrintKills, the object is destroyed before
            // been able to print the number of Kills

            Invoke("KillFakeKing", 5f);

            // Kills from duplicated king.
            //Just the instance that will be destroyed enters in that else.

            Debug.Log("Kills of the duplicated king (duplicated instace of KingOfTheWorld): " + Kills);

            // Kills from real king (static variable from singleton gameObject and persistent between scenes)
            //Debug.Log("Kills of the real king: "
            //    + CurrentKing.Kills);
        }
    }

    private void Update()
    {
        DebugKills();
    }

    void DebugKills()
    {
        if (timeToPrintKills > 0)
        {
            timeToPrintKills -= Time.deltaTime;
        }
        else
        {
            // My doubt was why name and Kills change with CurrentKing.name and CurrentKing.Kills
            // It's because of CurrentKing = this in the Awake() method.
            // "this" keyword refers to the MonoBehaviour that is instantianted.
            Debug.Log(name + " kills = " + Kills);

            // Event the instance that is destroyed prints the static data from the Real King.
            // Because this data is associated with class, not with instance.
            Debug.Log("Real King (static one): " + CurrentKing.name + " kills = " + CurrentKing.Kills);
            timeToPrintKills = 3f;
        }
    }

    void KillFakeKing()
    {
        Destroy(gameObject);
        Debug.Log("The only real King Of The World killed the fake king!");
        Debug.Log(gameObject.name + " (fake king):" + " I died because I am fake");
        KingOfTheWorld.CurrentKing.Kills++;
        string kingInspectorName = "KingOfTheWorld" + KingOfTheWorld.CurrentKing.Kills.ToString();
        FindObjectOfType<KingOfTheWorld>().name = kingInspectorName;
    }
}
