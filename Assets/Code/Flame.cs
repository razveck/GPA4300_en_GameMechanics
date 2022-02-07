//Author: João Azuaga

using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using UnityEngine;

namespace GameMechanics {
	public class Flame : MonoBehaviour {


		[SerializeField]
		private Gradient _gradient = default;


		[SerializeField]
		private AnimationCurve _scaleCurve = default;

		[SerializeField]
		private SpriteRenderer _sprite = default;

		[SerializeField]
		private float _timer = default;

		[SerializeField]
		private float _duration = 1f;

		private void Start() {
			_sprite.color = _gradient.Evaluate(_timer / _duration);
			transform.localScale = Vector3.one * _scaleCurve.Evaluate(_timer / _duration);
		}

		// Update is called once per frame
		private void Update() {
			_timer += Time.deltaTime;
			_sprite.color = _gradient.Evaluate(_timer / _duration);
			transform.localScale = Vector3.one * _scaleCurve.Evaluate(_timer / _duration);
		}
	}
}
