using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Follow : MonoBehaviour
{
    [SerializeField] Transform target;
    [SerializeField] float speed = 1f;
    [SerializeField] float floatSpeed = 1f;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Vector3.Distance(transform.position, target.position) > 6f) // move if distance from target is greater than 1
        {
            transform.position=Vector3.Lerp(transform.position, target.transform.position, Time.deltaTime * speed);
        }

        transform.localPosition = new Vector3(transform.localPosition.x, Mathf.Clamp(Mathf.Sin(Time.time * floatSpeed), -1, 1), transform.localPosition.z);
    }
}
