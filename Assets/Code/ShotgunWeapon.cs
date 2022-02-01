using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace GameMechanics
{
    public class ShotgunWeapon : Weapon
    {
        private float _bulletrotationLeft = -1; 
        private float _bulletrotationRight = 1;

        void Start()
        {
            maxAmmo = 5;
            currentAmmo = maxAmmo;
            reloadTime = 3f;
        }

        public override void Shoot()
        {
            if (currentAmmo <= 0)
            {
                StartCoroutine(Reload());
                return;
            }

            currentAmmo--;

            GameObject bulletL = Instantiate(_bulletPrefab, _spawnPoint.position * _bulletrotationLeft, transform.rotation);
            GameObject bulletR = Instantiate(_bulletPrefab, _spawnPoint.position * _bulletrotationRight, transform.rotation);
            GameObject bullet = Instantiate(_bulletPrefab, _spawnPoint.position, transform.rotation);

            Destroy(bulletL, 2f);
            Destroy(bulletR, 2f);
            Destroy(bullet, 2f);

            if (currentAmmo <= 0)
            {
                StartCoroutine(Reload());
            }

        }
    }
}
