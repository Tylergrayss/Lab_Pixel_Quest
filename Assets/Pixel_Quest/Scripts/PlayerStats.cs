using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerStats : MonoBehaviour
{
    public string nextLevel = "Scene_2";
    private void OnTriggerEnter2D(Collider2D collison)
    {
        Debug.Log("Hit");
        switch (collison.tag)
        {
            case "Death":
                {
                    string thisLevel = SceneManager.GetActiveScene().name;
                    SceneManager.LoadScene(thisLevel);
                    break;
                }
            case "Finish":
                {
                    Debug.Log("PlayerHasDied");
                    SceneManager.LoadScene(nextLevel);
                    break;
                }

        }
    }                            
}
