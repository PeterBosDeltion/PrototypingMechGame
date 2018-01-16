using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Weaponholder : MonoBehaviour {
    public Weapon weapon;
    private GameObject weaponObject;
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
            Debug.Log("PressedA");
            weapon.Use(transform.position);
        }
	}

    public void Setup()
    {
        weaponObject = Instantiate(weapon.armPrefab, transform.position, Quaternion.identity);
        weaponObject.transform.SetParent(transform);
    }

  
}
