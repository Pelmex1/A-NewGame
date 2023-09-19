using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerPicapScript : MonoBehaviour
{
    [SerializeField] private GameObject firewoodInHeand;
    [SerializeField] private GameObject firewoodOutHeand;
    // Start is called before the first frame update

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "fire")
        {
            firewoodInHeand.SetActive(true);
            Destroy(firewoodOutHeand);
        }
    }
}
