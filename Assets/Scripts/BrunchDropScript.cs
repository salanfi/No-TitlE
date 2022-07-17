using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BrunchDropScript : MonoBehaviour
{
    float time;
    public GameObject brunch;
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine("brunchdrop");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    IEnumerator brunchdrop()
    {
        while (true)
        {
            time = Random.Range(90, 300);
            yield return new WaitForSeconds(time);
            Instantiate(brunch, transform.position, transform.rotation);
        }
    }
}
