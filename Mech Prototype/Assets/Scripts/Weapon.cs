using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public abstract class Weapon : MonoBehaviour {
    public GameObject armPrefab;
    public enum weaponTypes
    {
        RocketLauncher,
        GatlingGun,
        MineLayer
    }
   
    public List<weaponTypes> typeWeapons = new List<weaponTypes>();
    public List<GameObject> projectileTypes = new List<GameObject>();

    public float damage;
    public float projectileSpeed;
    public float cooldown;


    public abstract void Use(Vector3 armPos);
   
	
}
