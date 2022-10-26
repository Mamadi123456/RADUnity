using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class newphysics : MonoBehaviour
{
    Rigidbody ourRigidBody;
    // Start is called before the first frame update
    void Start()
    {
        ourRigidBody = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {

        if(Input.GetKeyDown(KeyCode.UpArrow))

        ourRigidBody.AddExplosionForce(100000,transform.position+ Vector3.down,2 );
    }
    private void OnCollisionEnter(Collision collision)
    {
        
    }
}



