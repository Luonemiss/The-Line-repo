using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Interactor : MonoBehaviour
{
    public LayerMask interactableLayermask = 3;
    public Camera playerCamera;
    public bool ObjetTouche = false;

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
            ObjetTouche = true;
            Debug.Log(ObjetTouche + "viser un objet");
            
        } else {
            ObjetTouche = false;
            Debug.Log(ObjetTouche + "ne pas viser un objet");

            

        }

        if(ObjetTouche){
            hit.collider.transform.GetChild(0).gameObject.SetActive(true);

        } else {
            hit.collider.transform.GetChild(0).gameObject.SetActive(false);

        }

        /*Vector3 forward = transform.TransformDirection(Vector3.forward) * 10;
        Debug.DrawRay(transform.position, forward, Color.green);*/  
    
    }
}
