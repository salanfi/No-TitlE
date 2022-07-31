using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SunMoveScript : MonoBehaviour
{
    private GameObject obj;
    // Start is called before the first frame update
    void Start()
    {
        obj = GameObject.Find("Directional Light");
    }

    // Update is called once per frame
    void Update()
    {
        if (obj.transform.localEulerAngles.x <= 90)
        {
            obj.transform.Rotate(0.002f, 0, 0);
        }else if (obj.transform.localEulerAngles.x >= 270)
        {
            obj.transform.Rotate(0.05f, 0, 0);
        }
    }
}
