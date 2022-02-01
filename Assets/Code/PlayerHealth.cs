//Author: João Azuaga

using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace GameMechanics {
	public class PlayerHealth : HealthBase {
		protected override void Die() {
			SceneManager.LoadScene(gameObject.scene.buildIndex);
		}
	}
}
