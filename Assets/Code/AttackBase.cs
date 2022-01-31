using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace GameMechanics
{
    public abstract class AttackBase : MonoBehaviour
    {
        [SerializeField]
        public Weapon CurrentWeapon;

        protected abstract void Update();
        
        protected virtual Vector3 Aim()
        {

            Vector3 playerScreenPosition = Camera.main.WorldToScreenPoint(transform.position);

            Vector3 direction = Input.mousePosition - playerScreenPosition;

            float angle = Mathf.Atan2(direction.y, direction.x) * Mathf.Rad2Deg;

            Vector3 rotation = transform.rotation.eulerAngles;
            rotation.z = angle;

            transform.rotation = Quaternion.Euler(rotation);

            return rotation;
        }
    }
}   
