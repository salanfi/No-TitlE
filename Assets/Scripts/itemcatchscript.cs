using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class itemcatchscript : MonoBehaviour
{
    public int[] items = new int[] { 0, 0, 0 };
    public Text[] count = new Text[3];
    public GameObject[] brunchbundle;
    public GameObject[] smallstonebundle;
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
            count[0].text = "brunch :" + items[0].ToString();
        }else if (collision.gameObject.CompareTag("smallstone"))
        {
            items[1]++;
            count[1].text = "smallstone :" + items[1].ToString();
        }
        if (collision.gameObject.CompareTag("base"))
        {
            if(items[0] >= 5)
            {
                brunchbundle[0].SetActive(true);
            }
            if (items[0] >= 10)
            {
                brunchbundle[1].SetActive(true);
            }
            if (items[0] >= 20)
            {
                brunchbundle[2].SetActive(true);
            }
            if (items[0] >= 30)
            {
                brunchbundle[3].SetActive(true);
            }
            if (items[0] >= 40)
            {
                brunchbundle[4].SetActive(true);
            }
            if (items[0] >= 50)
            {
                brunchbundle[5].SetActive(true);
            }
            if (items[0] >= 60)
            {
                brunchbundle[6].SetActive(true);
            }
            if (items[1] >= 5)
            {
                smallstonebundle[0].SetActive(true);
            }
            if (items[1] >= 10)
            {
                smallstonebundle[1].SetActive(true);
            }
            if (items[1] >= 20)
            {
                smallstonebundle[2].SetActive(true);
            }
            if (items[1] >= 30)
            {
                smallstonebundle[3].SetActive(true);
            }
            if (items[1] >= 40)
            {
                smallstonebundle[4].SetActive(true);
            }
            if (items[1] >= 50)
            {
                smallstonebundle[5].SetActive(true);
            }
        }
    }
}
