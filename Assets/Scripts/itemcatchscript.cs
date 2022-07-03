using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class itemcatchscript : MonoBehaviour
{
    public int[] items = new int[] { 0, 0, 0 };
    public Text[] count = new Text[3];
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("item"))
        {
            items[0]++;
            count[0].text = "brunch:" + items[0].ToString();
        }
    }
}
