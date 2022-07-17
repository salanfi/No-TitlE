using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StoneCreateScript : MonoBehaviour
{
    float time;
    public GameObject stone;
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine("stonedrop");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    IEnumerator stonedrop()
    {
        while (true)
        {
            time = Random.Range(90, 300);
            yield return new WaitForSeconds(time);
            Instantiate(stone, transform.position, transform.rotation);
        }
    }
}
