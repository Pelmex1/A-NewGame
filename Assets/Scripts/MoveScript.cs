using System;
using UnityEngine;
using UnityEngine.UIElements;

public class MoveScript : MonoBehaviour
{
    [SerializeField] private float speed;
    private Rigidbody rigidbody;
    [SerializeField] private Animator animt;
    [SerializeField] private Animator animtWood;
    private void Start()
    {
        rigidbody = GetComponent<Rigidbody>();
    }
    void Update()
    {
        float vertical = Input.GetAxisRaw("Vertical");
        float horizontal = Input.GetAxisRaw("Horizontal");
        rigidbody.velocity = (new Vector3(horizontal * -1,0, vertical * -1) * Mathf.Clamp(speed, 1, 10));
        Vector3 velocity = rigidbody.velocity;
        rigidbody.velocity = new Vector3(Mathf.Clamp(velocity.x, -3 , 3),velocity.y, Mathf.Clamp(velocity.z, -2, 2));
        transform.rotation = Quaternion.LookRotation(new Vector3(horizontal, 0,vertical),Vector3.up);
        float totalvelocity = Mathf.Abs(rigidbody.velocity.x + rigidbody.velocity.z);
        animtWood.SetFloat("speed Wood", totalvelocity);
        animt.SetFloat("speed", totalvelocity);
    }
}
