using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace GameMechanics
{
    public class Weapon : MonoBehaviour
    {
        [SerializeField] private GameObject bulletPrefab;

        // Use this for initialization
        void Start()
        {
           
        }

        // Update is called once per frame
        void Update()
        {
            if(Input.GetMouseButtonDown(0))
            {
                Instantiate(bulletPrefab, Vector3.back, Quaternion.Euler(0f, 0f, 0f));

                Destroy(bulletPrefab, 2f);


            }
        }
    }
}
