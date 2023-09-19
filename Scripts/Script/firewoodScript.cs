using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace CheckFire
{
    public class firewoodScript : MonoBehaviour
    {
        public bool StartFire = false;
        private void OnCollisionEnter(Collision collision)
        {
            if (collision.transform.tag == "player")
            {
                gameObject.SetActive(false);
                StartFire = true;
                Debug.Log(StartFire);
            }
        }
    }
}


