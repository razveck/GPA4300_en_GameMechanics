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

		//readonly property
		public int MaxHealth => _maxHealth;

		[SerializeField]
		private int _currentHealth = 100;

		public event Action<int> HealthChanged;

		// Use this for initialization
		private void Start() {
			_currentHealth = _maxHealth;
			if(HealthChanged != null)
				HealthChanged.Invoke(_currentHealth);

			//this
			//HealthChanged.Invoke(_currentHealth);
			//is teh same as this
			//HealthChanged(_currentHealth);
		}

		public void TakeDamage(int damage) {
			_currentHealth = Mathf.Clamp(_currentHealth - damage, 0, _maxHealth);

			
			HealthChanged?.Invoke(_currentHealth);

			//exact same as this
			//if(HealthChanged != null)
			//	HealthChanged(_currentHealth);

			if(_currentHealth == 0)
				Die();
		}

		protected abstract void Die();
	}
}
