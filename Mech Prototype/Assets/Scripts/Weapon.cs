using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[CreateAssetMenu]
public class Weapon : ScriptableObject {
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

    
   public virtual void Use(Vector3 armPos)
    {

    }
	
}
