using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraScript : MonoBehaviour
{
    [SerializeField] private GameObject player;
    private Vector3 CurretPosition;
    // Start is called before the first frame update
    void Start()
    {
        CurretPosition = GetComponent<Transform>().position;
    }
    // Update is called once per frame
    void Update()
    {
      
        CurretPosition.z = Mathf.Lerp(transform.position.z,player.transform.position.z - 3, Time.deltaTime);
        CurretPosition.x = Mathf.Lerp(transform.position.x, player.transform.position.x - 10, Time.deltaTime);
        transform.position = CurretPosition;
    }
}
