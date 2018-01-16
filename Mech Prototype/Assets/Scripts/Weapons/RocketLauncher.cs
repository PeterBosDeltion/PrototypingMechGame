using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RocketLauncher : Weapon {
    
    private Rigidbody rb;
	// Use this for initialization
	void Start () {
        
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public override void Use(Vector3 armPos)
    {

        Debug.Log("You used me you filthy slut");
        GameObject g = Instantiate(base.projectileTypes[0], armPos, Quaternion.identity);
        rb = g.GetComponent<Rigidbody>();
        rb.AddForce(g.transform.forward * base.projectileSpeed * Time.deltaTime);
        Destroy(g, 2.0F);
    }

}
