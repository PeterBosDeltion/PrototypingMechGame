using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BodyHolder : MonoBehaviour {
    public GameObject bodyPrefab;
    public GameObject bodyObject;
    //private Body body;
    // Use this for initialization
    void Start () {
        Setup();
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    void Setup()
    {
        bodyObject = Instantiate(bodyPrefab, transform.position, Quaternion.identity);
        bodyObject.transform.SetParent(transform);
        bodyObject.transform.localRotation = new Quaternion(0, 0, 0, 0);
        bodyObject.transform.localPosition = Vector3.zero;
        //body = bodyObject.GetComponent<Body>();
       

    }
}
