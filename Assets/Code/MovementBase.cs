using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace GameMechanics {
	public class MovementBase : MonoBehaviour {

		[SerializeField]
		private float _speed = 5f;

		[SerializeField]
		protected Vector2 _direction;

		private void Update() {

		}

		protected virtual void Move() {
			transform.position += (Vector3)_direction.normalized * _speed * Time.deltaTime;
		}
	}
}
