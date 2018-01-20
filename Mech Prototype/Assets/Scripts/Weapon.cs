using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public abstract class Weapon : MonoBehaviour {
    public GameObject armPrefab;
    public GameObject bulletSpawnPos;
    public Image myCooler;
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
    public bool onCooldown;


    public abstract void Use(Vector3 armPos);

    public abstract IEnumerator Cooldown();

    public virtual void Cooler()
    {
        myCooler.enabled = true;
        float t = new float();
        t += Time.deltaTime / cooldown;
        myCooler.fillAmount = Mathf.Lerp(myCooler.fillAmount, 0, t);
    }

    public virtual void CoolerUpdate()
    {
        if (onCooldown)
        {
            Cooler();
        }
        else if (!onCooldown && myCooler.isActiveAndEnabled)
        {
            myCooler.fillAmount = 1;
            myCooler.enabled = false;
        }
    }


}
