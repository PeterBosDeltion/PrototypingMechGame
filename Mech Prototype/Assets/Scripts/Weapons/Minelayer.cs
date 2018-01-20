using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Minelayer : Weapon {
    private Rigidbody rb;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        base.CoolerUpdate();
	}

    public override void Use(Vector3 armPos)
    {
        if (!onCooldown)
        {
            GameObject g = Instantiate(base.projectileTypes[0], bulletSpawnPos.transform.position, Quaternion.identity);
            g.transform.rotation = GetComponentInParent<Player>().armsParent.transform.rotation;
            rb = g.GetComponent<Rigidbody>();
            rb.AddForce(GetComponentInParent<Player>().armsParent.transform.forward * projectileSpeed * Time.deltaTime);
            if(rb != null)
            {
                StartCoroutine(Mine());
            }
            StartCoroutine(Cooldown());
        }
    }

    IEnumerator Mine()
    {
        if(rb != null)
        {
            yield return new WaitForSeconds(.25F);
            rb.AddForce(Vector3.down * projectileSpeed / 4 * Time.deltaTime);
            rb.useGravity = true;
            rb.transform.rotation = Quaternion.identity;
        }
        
    }

    public override IEnumerator Cooldown()
    {
        onCooldown = true;
        yield return new WaitForSeconds(cooldown);
        onCooldown = false;
    }
}
