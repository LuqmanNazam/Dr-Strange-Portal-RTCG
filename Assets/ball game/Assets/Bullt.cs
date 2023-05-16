using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullt : MonoBehaviour
{
    public GameObject Bullet;

    public float speed = 20;
    
    // Update is called once per frame
    void Update()
    {
        
        
        
        if (Input.GetMouseButtonDown (0))
        {
            GameObject bullet = Instantiate(Bullet, transform.position, transform.rotation) 
            as GameObject;
            Rigidbody rig = bullet.GetComponent<Rigidbody>();
            rig.velocity = transform.forward * speed;
        }
    }
}
