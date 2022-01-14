using System.Collections;
using System.Collections.Generic;
using UnityEngine;



namespace GameMechanics {
	public sealed class EnemyMovement : MovementBase {


        [SerializeField] private Transform player;
        [SerializeField] LayerMask _mask = default;

        [SerializeField] private float detectionRange;
        private bool playerInDetectionRange = false;

        [SerializeField] private float stoppingRange;
        private bool playerInStoppingRange = false;

        private Vector2 patrolling;
        private float time = 0.0f;
        [SerializeField] private float InterpolationPeriod = 2.0f;
        private bool goingRight = true;
        

        private void Update()
        {
            // Patrolling
            time += Time.deltaTime;

            if(time>= InterpolationPeriod)
            {
                time -= InterpolationPeriod;

                if(goingRight == true)
                {
                    Vector2 patrollingDirection;

                    patrollingDirection.x = 1;
                    patrollingDirection.y = 0;
                    patrolling = patrollingDirection;
                    goingRight = false;
                }
                else
                {
                    Vector2 patrollingDirection;

                    patrollingDirection.x = -1;
                    patrollingDirection.y = 0;
                    patrolling = patrollingDirection;
                    goingRight = true;
                }
            }
            
            // Detection range
            Collider2D detectionCollider = Physics2D.OverlapCircle(transform.position, detectionRange, _mask);
            
                if (detectionCollider != null)
                {
                    playerInDetectionRange = true;
                }
                else
                    playerInDetectionRange = false;
            
            // Stopping range
            Collider2D stoppingCollider = Physics2D.OverlapCircle(transform.position, stoppingRange, _mask);
          
                if (stoppingCollider != null)
                {
                    playerInStoppingRange = true;
                }
                else
                    playerInStoppingRange = false;
            
                
            Move();
        }



        protected override Vector2 GetDirection()
        {
            if (playerInDetectionRange && playerInStoppingRange)
            {
                return Vector2.zero;
            }
            if (playerInDetectionRange)
            {
                Vector2 directionEnemy;
                directionEnemy.x = player.position.x - transform.position.x;
                directionEnemy.y = player.position.y - transform.position.y;

                return directionEnemy;
            }
            else
                return patrolling;

        }

        

    }
}