using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class KeyboardSpawner : MonoBehaviour
{
    [SerializeField] InputAction spawnAction = new InputAction(type: InputActionType.Button);
    [SerializeField] protected GameObject fireballPrefab;
    [SerializeField] protected Vector3 velocityOfFireball;

    protected virtual GameObject spawnObject(){
        Vector3 positionOfFireball = transform.position;
        Quaternion rotationOfFireball = Quaternion.identity;
        GameObject fireball = Instantiate(fireballPrefab, positionOfFireball, rotationOfFireball);
        Mover fireballMover = fireball.GetComponent<Mover>();
        if(fireballMover){
            fireballMover.SetVelocity(velocityOfFireball);
        }
        return fireball;
    }
    
     void OnEnable()
    {
        spawnAction.Enable();
    }

    void OnDisable()
    {
        spawnAction.Disable();
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(spawnAction.WasPressedThisFrame()){
            spawnObject();
        }
    }
}
