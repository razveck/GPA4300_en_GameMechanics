using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace GameMechanics
{
	public class EnemyAttack : AttackBase
	{
		[SerializeField]
		private PlayerAttack playerTarget;

		public float ShootRange;

		private void Start()
		{
			playerTarget = GameObject.FindObjectOfType<PlayerAttack>();
		}

		protected override Vector3 GetDirection()
		{
			Vector3 direction = playerTarget.transform.position - transform.position;

			return direction;
		}

		protected override bool ShouldShoot()
		{
			RaycastHit2D hit = Physics2D.Raycast(transform.position, transform.right);
			if (hit.collider != null && hit.distance <= ShootRange)
				return true;

			return false;
		}
	}
}
