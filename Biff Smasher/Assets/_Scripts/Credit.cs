using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Credit : MonoBehaviour
{
    [SerializeField] float speed = 1f;
    [SerializeField] string menu = "Menu";


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.up * Time.deltaTime * speed);
        if (Input.anyKeyDown)
        {
            SceneManager.LoadScene(menu);
        }
    }

    void OnBecameInvisible()
    {
        SceneManager.LoadScene(menu);
        Destroy(gameObject);
        
    }
}
