using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StartScreen : MonoBehaviour
{
    
    public void PlayGame(int sceneID){

        SceneManager.LoadScene(sceneID);

    }

    public void QuitGame(){
        Application.Quit();
    }
}
