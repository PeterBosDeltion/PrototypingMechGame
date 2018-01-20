using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Healthbar : MonoBehaviour {
    private Player player;
    public Image myBar;
	// Use this for initialization
	void Start () {
        player = GetComponentInParent<Player>();
        myBar = GetComponent<Image>();
	}
	
	// Update is called once per frame
	void Update () {
        HpBar();
	}

    void HpBar()
    {
        myBar.fillAmount = player.hp / 1000;
    }
}
