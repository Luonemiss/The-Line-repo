using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Interactor : MonoBehaviour
{
    public LayerMask interactableLayermask;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
         
        RaycastHit Hit;
        if (Physics.Raycast(Camera.main.transform.position, Camera.main.transform.forward, out Hit, 2, interactableLayermask))
        {
            Debug.Log("touchééé l'objet");
        }
    
    }
}
