//Author: João Azuaga

using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using UnityEngine;

namespace GameMechanics.Assets.Code {
	public class Mirrorer : MovementType {
		private Vector2 _direction;

		private void Update() {
			_direction.x = Input.GetAxisRaw("Horizontal");
			_direction.y = Input.GetAxisRaw("Vertical");
		}

		public override Vector2 CalculateMovement() {
			return _direction;
		}
	}
}
