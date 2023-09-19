using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerPut : MonoBehaviour
{
    [SerializeField] private GameObject firewoodInHeand;
    [SerializeField] private GameObject Prefab;
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "fire")
        {
            firewoodInHeand.SetActive(true);
        }
    }
}
