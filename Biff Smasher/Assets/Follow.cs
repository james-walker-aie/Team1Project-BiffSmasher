using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Follow : MonoBehaviour
{
    public Transform target;
    public float speed = 1f;



    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Vector3.Distance(transform.position, target.position) > 6f) // move if distance from target is greater than 1
        {
            transform.Translate(new Vector3(speed * Time.deltaTime,0, 0));
        }
    }
}
