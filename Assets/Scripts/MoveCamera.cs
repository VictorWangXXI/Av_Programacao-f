using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveCamera : MonoBehaviour
{
    public float speed;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.E))
        {
            transform.Translate(Vector3.right * Time.deltaTime * speed);
        }

        if (Input.GetKey(KeyCode.Q))
        {
            transform.Translate(Vector3.left * Time.deltaTime * speed);
        }

        if(transform.position.x>=3.6f)
        {
            transform.position = new Vector3(3.6f, 0, -10f);
        }
        if (transform.position.x <= -38f)
        {
            transform.position = new Vector3(-38f, 0, -10f);
        }
    }
}
