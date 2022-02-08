//Author: João Azuaga

using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using UnityEngine;
using UnityEngine.UI;

namespace GameMechanics {
	public class HealthHearts : MonoBehaviour {



		[SerializeField]
		private HealthBase _health = default;


		[SerializeField]
		private Image[] _hearts = default;

		// Use this for initialization
		private void Start() {
			_health.HealthChanged += OnHealthChanged;
		}

		private void OnDestroy() {
			_health.HealthChanged -= OnHealthChanged;
		}

		private void OnHealthChanged(int health) {
			for(int i = 0; i < _hearts.Length; i++) {
				//this math is wrong!!!
				_hearts[i].enabled = i < (float)health / _hearts.Length;
			}
		}
	}
}
