using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ObjetInteractible : MonoBehaviour
{
    public bool IsTouched = false;
    public GameObject Screen;
    public GameObject PorteAsc;
    public GameObject ImgEndFade;
    public GameObject SoundBroken;
    public bool DoorClosed;
    float transitionTime = 2f;
 
    //public transform enfant;
    // Start is called before the first frame update
    void Start()
    {
        //enfant.gameObject = this.transform.GetChild(0);
        
        
    }

    // Update is called once per frame
    void Update()
    {
        
        if(IsTouched){
            transform.GetChild(0).gameObject.SetActive(true);
            transform.GetChild(1).gameObject.SetActive(true);
            /*if(transform.GetChild(0).gameObject.activeSelf){
                transform.GetChild(0).gameObject.SetActive(true);
            }*/

            if (Input.GetMouseButtonDown(0)) {
            //Debug.Log("la souris");
            transform.GetChild(2).gameObject.SetActive(false);
            this.GetComponent<Collider>().enabled=false;

            if(PorteAsc != null){
                PorteAsc.GetComponent<ActivationAsc>().CloseDoor();
                DoorClosed = true;
            }

            if(Screen != null){
                Screen.SetActive(true);
            }

            if(Screen != SoundBroken){
                SoundBroken.SetActive(false);
            }

            if(this.GetComponent<AudioSource>() != null){
                this.GetComponent<AudioSource>().enabled=true;
            }


                if(this.GetComponent<NPCPath>() != null){
                    this.GetComponent<NPCPath>().enabled=true;
                    
                }

                if(this.GetComponent<RoombatPath>() != null){
                    this.GetComponent<RoombatPath>().enabled=true;
                }

            }
        } else{
            transform.GetChild(0).gameObject.SetActive(false);
            transform.GetChild(1).gameObject.SetActive(false);
            /*if(!transform.GetChild(0).gameObject.activeSelf){
                transform.GetChild(0).gameObject.SetActive(false);
            }*/
        }

        if(DoorClosed){
            StartCoroutine(LoadLevel("Menu"));
        }

    }

    IEnumerator LoadLevel( string nomScene){
        //jouer l'animation 
            if(ImgEndFade != null){
                ImgEndFade.SetActive(true);
                ImgEndFade.GetComponent<Animator>().Play("EndAnimation");
            }

            //att
            yield return new WaitForSeconds(transitionTime);

            //lancer la scène
            SceneManager.LoadScene(nomScene);

    }
}
