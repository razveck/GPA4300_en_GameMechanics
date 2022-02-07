using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace GameMechanics
{
	public abstract class AttackBase : MonoBehaviour
	{
		public Weapon CurrentWeapon = default;

		private void Update()
		{
			Aim();
			Shoot();
		}

		protected abstract Vector3 GetDirection();
		protected abstract bool ShouldShoot();


		protected void Aim()
		{
			Vector3 direction = GetDirection();

			float angle = Mathf.Atan2(direction.y, direction.x) * Mathf.Rad2Deg;

			Vector3 rotation = transform.rotation.eulerAngles;
			rotation.z = angle;

			transform.rotation = Quaternion.Euler(rotation);
		}

		protected void Shoot()
		{
			if (ShouldShoot())
				CurrentWeapon.Shoot();
		}
	}
}
