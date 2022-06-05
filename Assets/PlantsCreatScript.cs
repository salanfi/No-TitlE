using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlantsCreatScript : MonoBehaviour
{
    [SerializeField] GameObject plant;
    [SerializeField] int itemCount = 7;
    List<GameObject> items = new List<GameObject>();
    // Start is called before the first frame update
    void Start()
    {
        Transform myTransform = this.transform;
        Vector2 center = new Vector2(myTransform.position.x, myTransform.position.z);
        Vector3 halfExtents = new Vector3(30,30,30);
        for(int i = 0; i < itemCount; i++)
        {
            for(int n = 0; n < 10; n++)
            {
                Vector3 pos = Random.insideUnitCircle * 5 + center;
                pos.z = pos.y;
                pos.y = 0;
                if (!Physics.CheckBox(pos, halfExtents, Quaternion.identity,1<<20))
                {
                    GameObject obj = Instantiate(plant, pos, Quaternion.identity);
                    obj.transform.localScale = new Vector3(Random.Range(0.8f, 1.2f), Random.Range(0.8f, 1.2f), Random.Range(0.8f, 1.2f));
                    items.Add(obj);
                    break;
                }
            }
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
