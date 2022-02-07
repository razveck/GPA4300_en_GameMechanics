//Author: João Azuaga

using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using UnityEngine;

namespace GameMechanics{
	public class EnemyHealth : HealthBase {

		protected override void Die() {
			Destroy(gameObject);
		}

	}
}
