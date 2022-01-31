using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace GameMechanics
{
	[CreateAssetMenu(fileName = "New Weapon", menuName = "Weapon")]
	public class WeaponScriptableObject : ScriptableObject
    {
        public string weaponName;

        public int maxAmmo;
        

        public float reloadTime;
        public float fireRate;

        public GameObject weaponSprite;
    }
}
