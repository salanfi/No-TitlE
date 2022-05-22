using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CatMoveScript : MonoBehaviour
{
    [SerializeField] Animator anim;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    private Vector3 latestpos;
    void Update()
    {
        if (Input.GetKey("w"))
        {
            transform.position += transform.forward * 0.03f;
            anim.SetBool("Walk", true);
        }
        else
        {
            anim.SetBool("Walk", false);
        }
        Vector3 diff = transform.position - latestpos;
        latestpos = transform.position;
        if (diff.magnitude > 0.01f)
        {
            transform.rotation = Quaternion.LookRotation(diff);
        }
    }
}
