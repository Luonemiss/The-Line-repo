using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjetInteractible : MonoBehaviour
{
    public bool IsTouched = false;
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
            /*if(transform.GetChild(0).gameObject.activeSelf){
                transform.GetChild(0).gameObject.SetActive(true);
            }*/
        } else{
            transform.GetChild(0).gameObject.SetActive(false);
            /*if(!transform.GetChild(0).gameObject.activeSelf){
                transform.GetChild(0).gameObject.SetActive(false);
            }*/
        }

    }
}
