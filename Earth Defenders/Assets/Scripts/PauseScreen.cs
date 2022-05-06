using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseScreen : MonoBehaviour
{
    [SerializeField] GameObject paused;

    public void Pause(){
        paused.SetActive(true);
        //Time.timescale = 0f;

    }

    public void Resume(){
        paused.SetActive(false);
        //Time.timescale = 1f;

    }

    public void Home(int sceneID){
        //Time.timescale = 1f;
        SceneManager.LoadScene(sceneID);
    }

    public void Quit(){
        Application.Quit();
    }
}

