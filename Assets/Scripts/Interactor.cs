using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Interactor : MonoBehaviour
{
    public LayerMask NoninteractableLayermask = 6;
    public LayerMask interactableLayermask = 3;
    //public Gameobject CanvasText;

    public Camera playerCamera;

    private GameObject ReferenceDernierObjet;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        RaycastHit hit;

        if (Physics.Raycast(playerCamera.transform.position,playerCamera.transform.forward, out hit, 2, interactableLayermask))
        {
        
                ReferenceDernierObjet = hit.collider.gameObject;
                Debug.Log(ReferenceDernierObjet.name);
                ReferenceDernierObjet.GetComponent<ObjetInteractible>().IsTouched = true;

            
            //if(ReferenceDernierObjet != hit.collider.gameObject){}


            
        } else if(!Physics.Raycast(playerCamera.transform.position,playerCamera.transform.forward, out hit, 2, interactableLayermask)){

           if(ReferenceDernierObjet!=null){
                ReferenceDernierObjet.GetComponent<ObjetInteractible>().IsTouched = false;
            }
            //ReferenceDernierObjet = null;


        }

        

        /*Vector3 forward = transform.TransformDirection(Vector3.forward) * 10;
        Debug.DrawRay(transform.position, forward, Color.green);*/  
    
    }
}

