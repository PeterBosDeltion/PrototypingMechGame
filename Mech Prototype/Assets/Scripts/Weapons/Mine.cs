using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mine : MonoBehaviour {
    public float lifeTime;
    public float damage;
	// Use this for initialization
	void Start () {
        StartCoroutine(Life());
	}
	
	// Update is called once per frame
	void Update () {
		if(transform.position.y < 0)
        {
            transform.position = new Vector3(transform.position.x, 1, transform.position.z);
        }
	}

    IEnumerator Life()
    {
        yield return new WaitForSeconds(lifeTime);
        Destroy(gameObject);
    }

    public void OnCollisionEnter(Collision col)
    {
        if(col.transform.tag == "Player" && GetComponent<Rigidbody>().useGravity)
        {
           
                col.transform.GetComponent<Player>().hp -= damage;
                Destroy(gameObject);
        }
    }


}
