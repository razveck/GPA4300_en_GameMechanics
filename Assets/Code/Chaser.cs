//Author: João Azuaga

using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using UnityEngine;

namespace GameMechanics {
	public class Chaser : MovementType {

		[SerializeField] private Transform player;
		[SerializeField] LayerMask _mask = default;

		[SerializeField] private float detectionRange;
		private bool playerInDetectionRange = false;

		[SerializeField] private float stoppingRange;
		private bool playerInStoppingRange = false;

		private void Start() {
			if(TryGetComponent(out EnemyAttack attack)) {
				attack.ShootRange = detectionRange;
			}
		}

		// Update is called once per frame
		private void Update() {
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

		}

		public override bool CalculateMovement(out Vector2 direction) {
			if(playerInStoppingRange) {
				direction = Vector2.zero;
				return true;
			}
			if(playerInDetectionRange) {
				direction = player.position - transform.position;
				return true;
			}

			return base.CalculateMovement(out direction);
		}
	}
}
