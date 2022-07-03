using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimationController : MonoBehaviour
{
    Animator animator;
    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.W))
        {
            animator.SetBool("Walk", true);
        }else if (Input.GetKeyUp(KeyCode.W))
        {
            animator.SetBool("Walk", false);
        }
        if (Input.GetKey(KeyCode.A))
        {
            animator.SetBool("Walk", true);
        }
        else if (Input.GetKeyUp(KeyCode.A))
        {
            animator.SetBool("Walk", false);
        }
        if (Input.GetKey(KeyCode.S))
        {
            animator.SetBool("Walk", true);
        }
        else if (Input.GetKeyUp(KeyCode.S))
        {
            animator.SetBool("Walk", false);
        }
        if (Input.GetKey(KeyCode.D))
        {
            animator.SetBool("Walk", true);
        }
        else if (Input.GetKeyUp(KeyCode.D))
        {
            animator.SetBool("Walk", false);
        }
    }
}
