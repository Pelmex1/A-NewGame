using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraScript : MonoBehaviour
{
    [SerializeField] private GameObject player;
    private Vector3 CurretPosition;
    void Start()
    {
        CurretPosition = GetComponent<Transform>().position;
    }
    void Update()
    {
      
        CurretPosition.z = Mathf.Lerp(transform.position.z,player.transform.position.z - 6, Time.deltaTime);
        CurretPosition.x = Mathf.Lerp(transform.position.x, player.transform.position.x, Time.deltaTime);
        transform.position = CurretPosition;
    }
}
