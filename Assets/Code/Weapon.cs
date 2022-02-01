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


		[SerializeField]
		private int _bulletAmount = 1;

		[SerializeField]
		private float _angleDeviation = 0f;

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

			if(Time.time - _timeOfLastShot < _shotDelay) {
				return;
			}

			_timeOfLastShot = Time.time;

			currentAmmo--;

			//Quaternions are rotations in the engine
			//Euler angles (x, y,z in degrees)
			for(int i = 0; i < _bulletAmount; i++) {
				//1) convert rotation to euler angles
				Vector3 euler = transform.rotation.eulerAngles;
				//2) change the rotation
				euler.z += Random.Range(- _angleDeviation, _angleDeviation);
				//3) convert the euler angles to a quaternion
				Quaternion rotation = Quaternion.Euler(euler);

				GameObject bullet = Instantiate(_bulletPrefab, _spawnPoint.position, Quaternion.Euler(euler));

				Destroy(bullet, 2f);
			}

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
