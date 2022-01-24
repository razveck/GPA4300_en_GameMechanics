//Author: João Azuaga

using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using UnityEngine;

namespace GameMechanics {
	public class MovementType : MonoBehaviour {

		public virtual Vector2 CalculateMovement(){
			return Vector2.zero;
		}
		
	}
}
