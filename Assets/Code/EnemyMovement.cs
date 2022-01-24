using System.Collections;
using System.Collections.Generic;
using UnityEngine;



namespace GameMechanics {
	public sealed class EnemyMovement : MovementBase {


		[SerializeField] private Transform player;
		[SerializeField] LayerMask _mask = default;

		[SerializeField] private float detectionRange;
		private bool playerInDetectionRange = false;

		[SerializeField] private float stoppingRange;
		private bool playerInStoppingRange = false;

		private Vector2 patrolling;
		private float time = 0.0f;
		[SerializeField] private float InterpolationPeriod = 2.0f;
		private bool goingRight = true;


		protected override void Update() {
			// Patrolling
			time += Time.deltaTime;

			if(time >= InterpolationPeriod) {
				time -= InterpolationPeriod;

				if(goingRight == true) {
					patrolling.x = 1;
					patrolling.y = 0;
					goingRight = false;
				} else {
					patrolling.x = -1;
					patrolling.y = 0;
					goingRight = true;
				}
			}

			// Detection range
			Collider2D detectionCollider = Physics2D.OverlapCircle(transform.position, detectionRange, _mask);

			if(detectionCollider != null) {
				playerInDetectionRange = true;
			} else
				playerInDetectionRange = false;

			// Stopping range
			Collider2D stoppingCollider = Physics2D.OverlapCircle(transform.position, stoppingRange, _mask);

			if(stoppingCollider != null) {
				playerInStoppingRange = true;
			} else
				playerInStoppingRange = false;


			base.Update();
		}



		protected override Vector2 GetDirection() {
			if(playerInStoppingRange) {
				return Vector2.zero;
			}
			if(playerInDetectionRange) {
				return player.position - transform.position;
			}

			return patrolling;

			Vector2 direction;
			direction.x = Input.GetAxisRaw("Horizontal");
			direction.y = Input.GetAxisRaw("Vertical");

			return direction;
		}



	}
}