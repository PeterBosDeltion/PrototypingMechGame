using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class RocketLauncher : Weapon {
    
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
            g.GetComponent<Projectile>().damage = damage;
            g.GetComponent<Projectile>().myPlayerNumber = GetComponentInParent<Weaponholder>().player.playerNumber;
            rb = g.GetComponent<Rigidbody>();
            rb.AddForce(GetComponentInParent<Player>().armsParent.transform.forward * projectileSpeed * Time.deltaTime);
            Destroy(g, 2.0F);
            StartCoroutine(Cooldown());
        }
      
    }

    public override IEnumerator Cooldown()
    {
        onCooldown = true;
        yield return new WaitForSeconds(cooldown);
        onCooldown = false;
    }
}
