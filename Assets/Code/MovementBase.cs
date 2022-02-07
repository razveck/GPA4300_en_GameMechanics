using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace GameMechanics {
	public abstract class MovementBase : MonoBehaviour {

		[SerializeField]
		private float _speed = 5f;

		[SerializeField]
		protected Animator _animator;

		protected virtual void Update() {
			Move();
		}

		protected abstract Vector2 GetDirection();

		protected void Move() {
			//cache the direction
			Vector3 direction = GetDirection().normalized;
			transform.position += direction * _speed * Time.deltaTime;

			
		}
	}
}
