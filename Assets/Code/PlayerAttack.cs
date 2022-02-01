//Author: João Azuaga

using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using UnityEngine;

namespace GameMechanics {
    public class PlayerAttack : AttackBase
    {
        protected override Vector3 GetDirection()
        {
            Vector3 direction = Input.mousePosition - Camera.main.WorldToScreenPoint(transform.position);

            return direction;
        }

		protected override bool ShouldShoot() {
			return Input.GetMouseButtonDown(0);
		}
	}
}

