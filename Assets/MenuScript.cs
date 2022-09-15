using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement; 


public class MenuScript : MonoBehaviour
{
    public string LevelToLoad;
    public GameObject LesCredits;

    public Texture2D cursorTexture;
    public CursorMode cursorMode = CursorMode.Auto;
    public Vector2 hotSpot = Vector2.zero;

    public void Start(){
        LesCredits.SetActive(false);
        Cursor.SetCursor(cursorTexture, hotSpot, cursorMode);
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
