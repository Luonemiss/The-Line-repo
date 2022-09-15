using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement; 


public class MenuScript : MonoBehaviour
{
    public string LevelToLoad;
    public GameObject LesCredits;

    public void Start(){
        LesCredits.SetActive(false);
    }

    public void Retour(){
        LesCredits.SetActive(false);
    }

    public void Play(){
        SceneManager.LoadScene(LevelToLoad);
    }

    public void Credits(){
        LesCredits.SetActive(true);

    }

    public void Quit(){
        Application.Quit();
    }


}
