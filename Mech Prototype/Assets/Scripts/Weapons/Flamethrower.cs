using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Flamethrower : Weapon {
    public ParticleSystem parts;
    // Use this for initialization
    void Start () {
        parts = GetComponentInChildren<ParticleSystem>();
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public override void Use(Vector3 armPos)
    {
        if (!onCooldown)
        {
            parts.Play();
            StartCoroutine(Cooldown());
        }
    }

    public override IEnumerator Cooldown()
    {
        parts.Stop();
        onCooldown = true;
        yield return new WaitForSeconds(cooldown);
        onCooldown = false;
    }

}
