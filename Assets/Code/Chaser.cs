﻿//Author: João Azuaga

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

		public override Vector2 CalculateMovement() {
			if(playerInStoppingRange) {
				return Vector2.zero;
			}
			if(playerInDetectionRange) {
				return player.position - transform.position;
			}

			return base.CalculateMovement();
		}
	}
}