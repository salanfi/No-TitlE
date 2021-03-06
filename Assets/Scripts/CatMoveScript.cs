using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CatMoveScript : MonoBehaviour
{
    Vector3 movingdirection;
    public float speedmegnification;
    public Rigidbody rb;
    public Vector3 movingvelocity;
    public GameObject itemrist;
    public bool check = false;
    [SerializeField] Animator anim;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    private Vector3 latestpos;
    void Update()
    {
        float x = Input.GetAxisRaw("Horizontal");
        float z = Input.GetAxisRaw("Vertical");
        movingdirection = new Vector3(x, 0, z);
        movingdirection.Normalize();
        movingvelocity = movingdirection * speedmegnification;
        /*if (Input.GetKey("w"))
        {
            anim.SetBool("Walk", true);
        }
        else
        {
            anim.SetBool("Walk", false);
        }
        */
        rb.velocity = new Vector3(movingvelocity.x, rb.velocity.y, movingvelocity.z);
        /*if (Input.GetKeyDown("b"))
        {
            if (check == false)
            {
                itemrist.SetActive(true);
                check = true;
            }else if (check == true)
            {
                itemrist.SetActive(false);
                check = false;
            }
        }*/
    }
    void FixedUpdate()
    {
        Vector3 differencedis = new Vector3(transform.position.x, 0, transform.position.z) - new Vector3(latestpos.x, 0, latestpos.z);
        latestpos = transform.position;
        if (Mathf.Abs(differencedis.x) > 0.001f || Mathf.Abs(differencedis.z) > 0.001f)
        {
            if (movingdirection == new Vector3(0, 0, 0)) return;
            Quaternion rot = Quaternion.LookRotation(differencedis);
            rot = Quaternion.Slerp(rb.transform.rotation, rot, 0.2f);
            this.transform.rotation = rot;
        }
        if (jumpnow == true) return;
        
    }
    private bool jumpnow;
    public float jumpPower;
    private void OnCollisionEnter(Collision other)
    {
        if (jumpnow == true)
        {
            if (other.gameObject.CompareTag("field"))
            {
                jumpnow = false;
            }
        }
    }
    void jump()
    {
        if (jumpnow == true) return;
        if (Input.GetKeyDown(KeyCode.Space))
        {
            rb.AddForce(transform.up * jumpPower, ForceMode.Impulse);
            jumpnow = true;
        }
    }
    public void close()
    {
        itemrist.SetActive(false);
        check = false;
    }
}
