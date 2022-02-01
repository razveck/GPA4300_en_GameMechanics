using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace GameMechanics {
	public class Weapon : MonoBehaviour {

		[SerializeField]
		protected GameObject _bulletPrefab;
		[SerializeField]
		protected Transform _spawnPoint;

		[SerializeField]
		private float _shotDelay = 1f;
		[SerializeField]
		private float _timeOfLastShot;

		public int maxAmmo = 10;
		public int currentAmmo;
		public float reloadTime = 1f;

		public bool IsReloading;

		private void Start() {
			currentAmmo = maxAmmo;
		}

		public void Shoot() {
			if(IsReloading)
				return;

			if(currentAmmo <= 0) {
				StartCoroutine(Reload());
				return;
			}

			if(Time.time - _timeOfLastShot < _shotDelay){
				return;
			}

			_timeOfLastShot = Time.time;

			currentAmmo--;

			//Quaternions are rotations in the engine
			//Euler angles (x, y,z in degrees)
			GameObject bullet = Instantiate(_bulletPrefab, _spawnPoint.position, transform.rotation);

			Destroy(bullet, 2f);

			if(currentAmmo <= 0) {
				StartCoroutine(Reload());
			}
		}

		private IEnumerator Reload() {
			IsReloading = true;


			yield return new WaitForSeconds(reloadTime);
			currentAmmo = maxAmmo;
			IsReloading = false;
		}
	}
}
