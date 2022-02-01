//Author: João Azuaga

using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using UnityEngine;

namespace GameMechanics{
	public abstract class HealthBase : MonoBehaviour {


		[SerializeField]
		private int _maxHealth = 100;

		[SerializeField]
		private int _currentHealth = 100;

		// Use this for initialization
		private void Start() {
			_currentHealth = _maxHealth;
		}

		public void TakeDamage(int damage) {
			_currentHealth = Mathf.Clamp(_currentHealth - damage, 0, _maxHealth);

			if(_currentHealth == 0)
				Die();
		}

		protected abstract void Die();
	}
}
