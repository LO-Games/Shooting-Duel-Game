using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mover : MonoBehaviour
{
    [SerializeField] private Vector3 velocity = new Vector3(1, 0, 0);
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position += velocity * Time.deltaTime;
    }

    public void SetVelocity(Vector3 newVelocity){
        this.velocity = newVelocity;
    }
    
}
