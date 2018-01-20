using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Flame : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void OnParticleCollision(GameObject other)
    {
        if (other.tag == "Player" && other.GetComponent<Player>().playerNumber != GetComponentInParent<Player>().playerNumber)
        {
            Debug.Log("Hit opponent");
            Player hitPlayer = other.GetComponent<Player>();
            hitPlayer.hp -= GetComponentInParent<Flamethrower>().damage;
        }
    }
}
