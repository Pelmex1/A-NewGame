using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using CheckFire;
using System.Runtime.InteropServices;
using Unity.PlasticSCM.Editor.WebApi;
using TMPro;

public class FireScript : MonoBehaviour
{
    [SerializeField] private float TimeEndGame;
    [SerializeField] private GameObject Panel;
    [SerializeField] private TMP_Text text;
    bool EndGame = false;
    void Update()
    {
        if(!EndGame)
        {
            TimeEndGame -= Time.deltaTime;
            if (TimeEndGame <= 0)
            {
                EndGame = true;
            }
        }
        if(EndGame)
        {
            Panel.SetActive(true);
        }
        text.text = "Осталось время: " + (int)TimeEndGame + " с.";
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
