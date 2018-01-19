using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Weaponholder : MonoBehaviour {
    public GameObject weaponObject;
    private Weapon weapon;
    private Player player;
	// Use this for initialization
	void Start () {
        player = GetComponentInParent<Player>();
        Setup();
	}
	
	// Update is called once per frame
	void Update () {
		if(player.playerNumber == 1 && Input.GetButtonDown("Abutton"))
        {
            weapon.Use(transform.position);
        }
        else if (player.playerNumber == 2 && Input.GetButtonDown("AbuttonPtwo"))
        {
            weapon.Use(transform.position);
        }
    }

    public void Setup()
    {
        weaponObject = Instantiate(weaponObject, player.armsParent.transform.position, transform.rotation);
        weaponObject.transform.SetParent(transform);
        weaponObject.transform.localRotation = new Quaternion(-90, 0, 0, 0);
        weaponObject.transform.localPosition = Vector3.zero;
        weapon = weaponObject.GetComponent<Weapon>();
    }

  
}
