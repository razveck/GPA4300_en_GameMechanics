using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace GameMechanics {
	public class Weapon : MonoBehaviour {
		[SerializeField]
		private GameObject _bulletPrefab;

		[SerializeField]
		private Transform _spawnPoint;

		// Use this for initialization
		void Start() {

		}

		public void Shoot() {
			//Quaternions are rotations in the engine
			//Euler angles (x, y,z in degrees)

			GameObject bullet = Instantiate(_bulletPrefab, _spawnPoint.position, transform.rotation);

			Destroy(bullet, 2f);
		}
	}
}
