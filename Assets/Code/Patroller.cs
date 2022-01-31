//Author: João Azuaga

using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using UnityEngine;

namespace GameMechanics {
	public class Patroller : MovementType {

		private Vector2 patrolling;
		private float time = 0.0f;
		[SerializeField] private float InterpolationPeriod = 2.0f;
		private bool goingRight = true;


		private void Update() {
			// Patrolling
			time += Time.deltaTime;
		}

		public override bool CalculateMovement(out Vector2 direction) {
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

			direction = patrolling;
			return true;
		}

		//a function called Add
		//input is 2 ints
		//output is the sum as an int
		//output = return value
		//input = parameters
		int Add(int a, int b) {
			return a + b;
		}

	}
}
