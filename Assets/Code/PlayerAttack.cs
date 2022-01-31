//Author: João Azuaga

using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using UnityEngine;

namespace GameMechanics {
	public class PlayerAttack : AttackBase {

        protected override void Update()
        {
            Aim();

            if (Input.GetMouseButtonDown(0))
            {
                if (CurrentWeapon.IsReloading)
                    return;

                CurrentWeapon.Shoot();
            }
        }

	}
}
        


           

            

        

       
