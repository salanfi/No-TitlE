using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CatMoveScript : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey("w"))
        {
            transform.position += new Vector3(0, 0, 0.1f);
        }
        if (Input.GetKey("s"))
        {
            transform.position += new Vector3(0, 0, -0.1f);
        }
        if (Input.GetKey("a"))
        {
            transform.position += new Vector3(-0.1f, 0, 0);
        }
        if (Input.GetKey("d"))
        {
            transform.position += new Vector3(0.1f, 0, 0);
        }
    }
}
