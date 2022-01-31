using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace GameMechanics
{
    public class EnemyAttack : AttackBase
    {
        [SerializeField]
        private Chaser chasingEnemy;
        [SerializeField]
        private PlayerAttack playerTarget;

        public Transform playerLocation;

        private Vector3 direction;

      

        private void Start()
        {
            
            playerTarget = GameObject.FindObjectOfType<PlayerAttack>();

        }

        protected override void Update()
        {
            if (chasingEnemy.playerInDetectionRange == true)
                CurrentWeapon.Shoot();
            else
                return;
        }

        protected override Vector3 Aim()
        {
            

            return base.Aim();
           
        }


    }
}
