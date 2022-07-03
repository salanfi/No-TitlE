using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemristController : MonoBehaviour
{
    public GameObject itemrist;
    public bool check = false;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown("b"))
        {
            if (check == false)
            {
                itemrist.SetActive(true);
                check = true;
            }
            else if (check == true)
            {
                itemrist.SetActive(false);
                check = false;
            }
        }
    }
    public void close()
    {
        itemrist.SetActive(false);
        check = false;
    }
}
