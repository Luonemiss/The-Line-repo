using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ActivationAsc : MonoBehaviour
{
    public bool IsTouched;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

    }

    void OnTriggerEnter(Collider col)
    {
        if(col.tag =="Player"){
            this.transform.GetChild(0).GetComponent<Animator>().SetTrigger("IsTriggered");
            this.transform.GetChild(1).GetComponent<Animator>().SetTrigger("IsTriggered");
        }

            
    }

    public void CloseDoor(){
        this.transform.GetChild(0).GetComponent<Animator>().ResetTrigger("IsTriggered");
        this.transform.GetChild(1).GetComponent<Animator>().ResetTrigger("IsTriggered");
    }
}
