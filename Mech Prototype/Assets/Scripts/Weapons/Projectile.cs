using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Projectile : MonoBehaviour {
    public float damage;
    public int myPlayerNumber;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void OnCollisionEnter(Collision col)
    {
        if(col.transform.tag == "Player")
        {
            Player p = col.transform.GetComponent<Player>();
            if(p.playerNumber != myPlayerNumber)
            {
                p.hp -= Mathf.RoundToInt(damage);
                Destroy(gameObject);
            }
        }
        else
        {
            Destroy(gameObject);
        }
    }
}
