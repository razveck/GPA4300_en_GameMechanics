using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace GameMechanics {
	public class ProjectileMovement : MovementBase {


		protected override Vector2 GetDirection() {
			//can we get a Vector3 that corresponds to the x (red) axis of a transform?
			return transform.right;
		}
	}
}
