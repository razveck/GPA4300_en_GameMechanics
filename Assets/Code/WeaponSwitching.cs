using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace GameMechanics {

	public class WeaponSwitching : MonoBehaviour {
		public int selectedWeapon = 0;

		public List<Weapon> Weapons;

		public PlayerAttack Player;


		// Start is called before the first frame update
		private void Start() {
			foreach(Weapon weapon in Weapons) {
				weapon.gameObject.SetActive(false);
			}

			Player.CurrentWeapon = Weapons[selectedWeapon];

			SelectWeapon();
		}

		public void Update() {
			int previousSelectedWeapon = selectedWeapon;

			if(Input.GetAxis("Mouse ScrollWheel") > 0f) {
				if(selectedWeapon >= Weapons.Count - 1)
					selectedWeapon = 0;
				else
					selectedWeapon++;
			}
			if(Input.GetAxis("Mouse ScrollWheel") < 0f) {
				if(selectedWeapon <= 0)
					selectedWeapon = Weapons.Count - 1;
				else
					selectedWeapon--;
			}

			if(previousSelectedWeapon != selectedWeapon) {
				SelectWeapon();
			}
		}

		private void SelectWeapon() {
			Player.CurrentWeapon.gameObject.SetActive(false);
			Player.CurrentWeapon.IsReloading = false;

			Player.CurrentWeapon = Weapons[selectedWeapon];
			Player.CurrentWeapon.gameObject.SetActive(true);

		}
	}
}
