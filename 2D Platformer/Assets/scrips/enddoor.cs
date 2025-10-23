using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;

public class enddoor : MonoBehaviour
{
    public bool finalLevel;
    public string nextLevelName;

    private void OnTriggerEnter2D (Collider2D collision)
    {
        if(finalLevel == true)
        {
            SceneManager.LoadScene(0);
        }


        else
        {
            SceneManager.LoadScene(nextLevelName);
        }
    
    }

    

   
}
