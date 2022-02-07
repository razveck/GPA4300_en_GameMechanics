using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace GameMechanics {
	public sealed class PlayerMovement : MovementBase {


		protected override Vector2 GetDirection() {
			Vector2 direction;
			direction.x = Input.GetAxisRaw("Horizontal");
			direction.y = Input.GetAxisRaw("Vertical");

			if(direction == Vector2.zero)
				_animator.SetBool("walking", false);
			else
				_animator.SetBool("walking", true);

			return direction;
		}


	}
}
