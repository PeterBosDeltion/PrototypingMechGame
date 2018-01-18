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

        Debug.Log("used");
        GameObject g = Instantiate(base.projectileTypes[0], armPos, Quaternion.identity);
        g.transform.rotation = transform.rotation;
        rb = g.GetComponent<Rigidbody>();
        rb.AddForce(g.transform.forward * projectileSpeed * Time.deltaTime);
        Destroy(g, 2.0F);
    }

}
