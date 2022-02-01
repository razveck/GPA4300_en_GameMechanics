using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace GameMechanics
{
    public abstract class AttackBase : MonoBehaviour
    {
        //[SerializeField]
        //public Weapon CurrentWeapon = default;

        protected virtual void Update()
        {
            Aiming();
        }

        protected abstract Vector3 GetPlayerScreenPosition();
        protected abstract Vector3 GetDirection();
        protected abstract Vector3 GetRotation();


        protected void Aiming()
        {
            Vector3 playerScreenPosition = GetPlayerScreenPosition();

            Vector3 direction = GetDirection();

            float angle = Mathf.Atan2(direction.y, direction.x) * Mathf.Rad2Deg;

            Vector3 rotation = GetRotation();
            rotation.z = angle;

            transform.rotation = Quaternion.Euler(rotation);

            //if (Input.GetMouseButtonDown(0))
            //{
            //    if (CurrentWeapon.IsReloading)
            //        return;

            //    CurrentWeapon.Shoot();

            //}
        }
    }
}
    

