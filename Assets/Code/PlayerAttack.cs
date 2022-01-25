//Author: João Azuaga

using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using UnityEngine;

namespace GameMechanics {
	public class PlayerAttack : MonoBehaviour {

		[SerializeField]
		private Weapon _currentWeapon = default;

		// Use this for initialization
		private void Start() {

		}

		// Update is called once per frame
		private void Update() {
			Vector3 playerScreenPosition = Camera.main.WorldToScreenPoint(transform.position);

			Vector3 direction = Input.mousePosition - playerScreenPosition;

			float angle = Mathf.Atan2(direction.y, direction.x) * Mathf.Rad2Deg;

			Vector3 rotation = transform.rotation.eulerAngles;
			rotation.z = angle;

			transform.rotation = Quaternion.Euler(rotation);


			if(Input.GetMouseButtonDown(0)) {
				_currentWeapon.Shoot();
			}
		}
	}
}
