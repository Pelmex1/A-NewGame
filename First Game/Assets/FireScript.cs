using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using CheckFire;
using System.Runtime.InteropServices;
using Unity.PlasticSCM.Editor.WebApi;

public class FireScript : MonoBehaviour
{
    [SerializeField] private float TimeEndGame;
    [SerializeField] private GameObject Panel;
    // Update is called once per frame
    void Update()
    {
        bool EndGame = false;
        if (EndGame == false)
        {
            TimeEndGame -= Time.deltaTime;
            if (TimeEndGame <= 0)
            {
                EndGame = true;
            }
        }
        if (EndGame == true)
        {
            Panel.SetActive(true);
        }
    }
    public void OnCollisionEnter(Collision collision)
    {
        firewoodScript check = collision.gameObject.GetComponent<firewoodScript>();
        if (collision.transform.tag == "player" && check.StartFire == true)
        {
            TimeEndGame += 5;
            Debug.Log(TimeEndGame);
            check.StartFire = false;
            check.gameObject.SetActive(true);
        }
    }
}
