using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace GameMechanics {
	public abstract class MovementBase : MonoBehaviour {

		[SerializeField]
		private float _speed = 5f;

		protected virtual void Update() {
			Move();
		}

		protected abstract Vector2 GetDirection();

		protected void Move() {
			transform.position += (Vector3)GetDirection().normalized * _speed * Time.deltaTime;
		}
	}
}
