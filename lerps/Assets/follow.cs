using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class follow : MonoBehaviour
{

    Vector3 reletivePosition;
    Quaternion targetRotation;

    public Transform target;
    public float speed = 0.1F;

    bool rotating = false;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        reletivePosition = target.position - transform.position;
        targetRotation = Quaternion.LookRotation(reletivePosition);
        rotating = true;

        transform.rotation = Quaternion.Lerp(transform.rotation, targetRotation, Time.time * speed);


    }
}
