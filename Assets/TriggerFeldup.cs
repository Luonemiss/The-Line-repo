using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerFeldup : MonoBehaviour
{
    public GameObject SonFeldup;
    public GameObject Player;
    // Start is called before the first frame update
    void Start()
    {
        Player = GameObject.Find("Player");
        SonFeldup = GameObject.Find("SonFeldup");

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter(Collider col)
    {
        if(col.tag =="Player"){
            Player.GetComponent<AudioSource>().enabled=false;

            //Récupérer l'enfant et l'activer pour entendre feldup
            SonFeldup.GetComponent<AudioSource>().enabled=true;
        }

            
    }
}
