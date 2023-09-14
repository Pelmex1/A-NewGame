using System;
using UnityEngine;
using UnityEngine.UIElements;

public class MoveScript : MonoBehaviour
{
    [SerializeField] private GameObject move;
    [SerializeField] private float speed;
    // Start is called before the first frame update
    void Start()
    {
        move.GetComponent<Rigidbody>();
    }
    // Update is called once per frame
    void Update()
    {
        float vertical = Input.GetAxisRaw("Vertical");
        float horizontal = Input.GetAxisRaw("Horizontal");
        move.GetComponent<Rigidbody>().AddForce(new Vector3(horizontal,0, vertical) * Mathf.Clamp(speed, 1, 10));
        Vector3 velocity = move.GetComponent<Rigidbody>().velocity;
        move.GetComponent<Rigidbody>().velocity = new Vector3(Mathf.Clamp(velocity.x, -3 , 3),velocity.y, Mathf.Clamp(velocity.z, -2, 2));
    }
}
