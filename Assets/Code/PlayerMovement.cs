using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace GameMechanics {
	public class PlayerMovement : MovementBase {

		//we're reading the player input in Move()
		//but Move() is never called

		//A) we call Move() somewhere
		//B) we get input somewhere else

		private void Update() {
			_direction.x = Input.GetAxisRaw("Horizontal");
			_direction.y = Input.GetAxisRaw("Vertical");
			
			Move();
		}
	}
}
