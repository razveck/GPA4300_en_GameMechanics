//Author: João Azuaga

using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using UnityEngine;

namespace GameMechanics {
    public class PlayerAttack : AttackBase
    {
        Vector3 playerScreenPosition;


        protected override Vector3 GetPlayerScreenPosition()
        {
            playerScreenPosition = Camera.main.WorldToScreenPoint(transform.position);

            return playerScreenPosition;
        }

        protected override Vector3 GetDirection()
        {
            Vector3 direction = Input.mousePosition - playerScreenPosition;

            return direction;
        }

        protected override Vector3 GetRotation()
        {
            Vector3 rotation = transform.rotation.eulerAngles;

            return rotation;
        }













        //[SerializeField]
        //public Weapon CurrentWeapon = default;

        //// Use this for initialization
        //private void Start() {

        //}

        //// Update is called once per frame
        //private void Update() {
        //	Vector3 playerScreenPosition = Camera.main.WorldToScreenPoint(transform.position);

        //	Vector3 direction = Input.mousePosition - playerScreenPosition;

        //	float angle = Mathf.Atan2(direction.y, direction.x) * Mathf.Rad2Deg;

        //	Vector3 rotation = transform.rotation.eulerAngles;
        //	rotation.z = angle;

        //	transform.rotation = Quaternion.Euler(rotation);


        //	if(Input.GetMouseButtonDown(0)) {
        //		if (CurrentWeapon.IsReloading)
        //			return;

        //		CurrentWeapon.Shoot();
        //	}
    }
}

