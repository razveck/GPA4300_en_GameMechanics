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
			foreach(MovementType type in _movementTypes){
				if(type.CalculateMovement(out Vector2 direction)){
					_animator.SetBool("walking", true);
					return direction;
				}
			}

			_animator.SetBool("walking", false);

			return Vector2.zero;
		}



	}
}