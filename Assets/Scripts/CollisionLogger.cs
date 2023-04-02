using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollisionLogger : MonoBehaviour
{
    // Start is called before the first frame update
    private void Start()
    {
        Debug.Log("Start Collision on" + this.name);
    }

    private void OnTriggerEnter(Collider other){
        Debug.Log(this.name + " Trigger with " + other.name + " tag=" + other.tag);
    }
    
    // Update is called once per frame
    void Update()
    {
        
    }
}
