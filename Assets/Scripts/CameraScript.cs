using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraScript : MonoBehaviour
{
    [SerializeField] private GameObject player;
    private Vector3 CurrentPosition;
    void Start()
    {
        CurrentPosition = GetComponent<Camera>().GetComponent<Transform>().position;
    }
    void Update()
    {
        CurrentPosition.z = Mathf.Lerp(transform.position.z,player.transform.position.z - 4, Time.deltaTime);
        CurrentPosition.x = Mathf.Lerp(transform.position.x, player.transform.position.x, Time.deltaTime);
        CurrentPosition.y = Mathf.Lerp(transform.position.y, player.transform.position.y + 3, Time.deltaTime);
        transform.position = CurrentPosition;
    }
}
