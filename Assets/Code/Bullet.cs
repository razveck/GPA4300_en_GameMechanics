using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace GameMechanics
{
    public class Bullet : MonoBehaviour
    {

        private void OnTriggerEnter2D (Collider2D collider2D)
        {
            Debug.Log("Bullet hit something");

            Destroy(gameObject);
        }
    }
}
