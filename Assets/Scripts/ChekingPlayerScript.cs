using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChekingPlayerScript : MonoBehaviour
{
    // Start is called before the first frame update

    public bool StartFire = false;

    private void OnCollisionEnter(Collision collision)
    {
        if(collision.transform.tag == "fire")
        {
            StartFire = true;
        }
    }
}
