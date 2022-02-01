using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace GameMechanics {
	public class Bullet : MonoBehaviour {

		[SerializeField]
		private int _damage = 10;

		private void OnTriggerEnter2D(Collider2D collider2D) {
			if(collider2D.TryGetComponent(out HealthBase health)) {
				health.TakeDamage(_damage);
			}

			Destroy(gameObject);
		}
	}
}
