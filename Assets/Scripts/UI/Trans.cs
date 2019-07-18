using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class Trans : MonoBehaviour
{
    public GameObject PauseMenu;
    public void LoadScene(int number) 
    {
        StartCoroutine(LoadSceneFunction(number));      
    }

    IEnumerator LoadSceneFunction(int number) 
    {

        if (PauseMenu != null)
        {
            PauseMenu.SetActive(false);
        }

        Time.timeScale = 1;
        yield return new WaitForSeconds(12f/60f);
        SceneManager.LoadScene(number);

    }
}
