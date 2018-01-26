using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Piston : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        transform.Translate(transform.forward * 5 * Time.deltaTime);
	}
}
