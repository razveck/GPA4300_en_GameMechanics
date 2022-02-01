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

        public float ShootRange;

        private void Start()
        {
            
            playerTarget = GameObject.FindObjectOfType<PlayerAttack>();

        }

        protected override void Update()
        {
            float distance = Vector2.Distance(playerTarget.transform.position, transform.position);

            RaycastHit2D hit = Physics2D.Raycast(transform.position, transform.right);
            if(hit.collider == null)
                return;

            if (hit.distance <= ShootRange)
                CurrentWeapon.Shoot();
        }

        protected override Vector3 Aim()
        {
            

            return base.Aim();
           
        }


    }
}
