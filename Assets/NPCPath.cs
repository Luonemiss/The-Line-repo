using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NPCPath : MonoBehaviour
{
    public Transform[] target;
    public float speed;
    public float damping = 6.0f;

    public int current;


    // Update is called once per frame
    void Update()
    {
        Debug.Log(current);
        Debug.Log("position du NPC" + transform.position);
        Debug.Log("position de la target" + target[current].position);

        if(transform.position != target[current].position){

            Vector3 pos = Vector3.MoveTowards(transform.position,target[current].position, speed * Time.deltaTime);
            GetComponent<Rigidbody>().MovePosition(pos);

           var rotation = Quaternion.LookRotation(target[current].position - transform.position);
            transform.rotation = Quaternion.Slerp(transform.rotation, rotation, Time.deltaTime * damping);
        } else current = (current + 1) % target.Length;
        
    }
}
