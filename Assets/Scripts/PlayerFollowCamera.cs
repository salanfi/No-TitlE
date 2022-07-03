using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerFollowCamera : MonoBehaviour
{
    [SerializeField] private Transform player;
    [SerializeField] private float distance = 3.0f;
    [SerializeField] private Quaternion vRotation;
    [SerializeField] public Quaternion hRotation;
    [SerializeField] private float turnSpeed = 5.0f;
    // Start is called before the first frame update
    void Start()
    {
        vRotation = Quaternion.Euler(30, 0, 0);
        hRotation = Quaternion.identity;
        transform.rotation = transform.rotation*hRotation * vRotation;
        transform.position = player.position + new Vector3(0, 3, 0) - transform.rotation * Vector3.forward * distance;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void LateUpdate()
    {
        hRotation *= Quaternion.Euler(0, Input.GetAxis("Mouse X") * turnSpeed, 0);
        transform.rotation = hRotation * vRotation;
        transform.position = player.position - transform.rotation * Vector3.forward * distance;
    }
}
