using System.Collections;
using UnityEngine;

namespace GameMechanics {
	public class EnemyMovement : MovementBase {
		protected override Vector2 GetDirection() {

			Vector2 direction;
			direction.x = Input.GetAxisRaw("Horizontal");
			direction.y = Input.GetAxisRaw("Vertical");

			return direction;
		
			
		}
	}
}