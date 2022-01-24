using System.Collections;
using System.Collections.Generic;
using UnityEngine;



namespace GameMechanics {
	public sealed class EnemyMovement : MovementBase {

		[SerializeField]
		private List<MovementType> _movementTypes = new List<MovementType>();

		protected override void Update() {
			base.Update();
		}



		protected override Vector2 GetDirection() {
			Vector2 zero = Vector2.zero;

			foreach(MovementType type in _movementTypes){
				Vector2 result = type.CalculateMovement();
				if(result != zero)
					return result;
			}

			return zero;
		}



	}
}