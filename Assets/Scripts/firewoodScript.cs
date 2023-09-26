using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace CheckFire
{
    public class firewoodScript : MonoBehaviour
    {
        private void OnCollisionEnter(Collision collision)
        {
            if (collision.transform.tag == "Player")
            {
                gameObject.SetActive(false);
                ChangPosition();
            }
        }

        private void ChangPosition()
        {
            float randomX = Random.Range(1, 10);
            float randomZ = Random.Range(-10, 10);
            transform.position = new Vector3(randomX,1, randomZ);
            gameObject.SetActive(true);
        }
    }
}


