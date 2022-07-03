using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CatmoveScript1 : MonoBehaviour
{
    [SerializeField] private Vector3 velocity;
    [SerializeField] private float movespeed = 1.5f;
    [SerializeField] private float applyspeed = 0.2f;
    [SerializeField] private PlayerFollowCamera refCamera;
    private bool jumpnow = false;
    public float jumpPower = 850;
    public Rigidbody rb;
    Animator animator;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        velocity = Vector3.zero;
        if (Input.GetKey(KeyCode.W))
        {
            velocity.z += 1;
        }
        if (Input.GetKey(KeyCode.A))
            velocity.x -= 1;
        if (Input.GetKey(KeyCode.S))
            velocity.z -= 1;
        if (Input.GetKey(KeyCode.D))
            velocity.x += 1;

        velocity = velocity.normalized * movespeed * Time.deltaTime;
        if (velocity.magnitude > 0)
        {
            transform.rotation = Quaternion.Slerp(transform.rotation, Quaternion.LookRotation(refCamera.hRotation * velocity), applyspeed);
            transform.position += refCamera.hRotation * velocity;
        }
        if (Input.GetKeyDown(KeyCode.Space))
        {
            rb.AddForce(new Vector3(0, jumpPower, 0));
        }
    }
}
