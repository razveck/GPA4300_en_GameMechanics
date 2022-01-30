using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace GameMechanics {
	public class Weapon : MonoBehaviour {
		
		[SerializeField]
		protected GameObject _bulletPrefab;
		[SerializeField]
		protected Transform _spawnPoint;

		public int maxAmmo = 10;
		public  int currentAmmo;
		public float reloadTime = 1f;

		public bool IsReloading;

        private void Start()
        {
			currentAmmo = maxAmmo;
        }
        private void Update()
        {
			if (IsReloading)
				return;

            if(currentAmmo <= 0)
            {
				StartCoroutine(Reload());
				return;
            }
        }

        public void Shoot() {
			//Quaternions are rotations in the engine
			//Euler angles (x, y,z in degrees)
			currentAmmo--;

			GameObject bullet = Instantiate(_bulletPrefab, _spawnPoint.position, transform.rotation);

			Destroy(bullet, 2f);
		}
       IEnumerator Reload()
        {
			IsReloading = true;
			

			yield return new WaitForSeconds(reloadTime);
			currentAmmo = maxAmmo;
			IsReloading = false;
        }
	}
}
