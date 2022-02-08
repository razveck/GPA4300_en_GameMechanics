//Author: João Azuaga

using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using UnityEngine;
using UnityEngine.UI;

namespace GameMechanics {
	public class HealthBar : MonoBehaviour {


		[SerializeField]
		private HealthBase _health = default;


		[SerializeField]
		private Image _bar = default;

		// Use this for initialization
		private void Start() {
			_health.HealthChanged += OnHealthChanged;
		}

		private void OnDestroy() {
			_health.HealthChanged -= OnHealthChanged;
		}

		private void OnHealthChanged(int health) {
			_bar.fillAmount = (float)health / _health.MaxHealth;
		}
	}
}
