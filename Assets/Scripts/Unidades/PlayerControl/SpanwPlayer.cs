using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class SpanwPlayer : MonoBehaviour
{
    public GameObject player;
    public bool invocou;
    public GameObject mainCamera;
    public string playerName;
    public string playerCloneName;

    // Start is called before the first frame update
    void Start()
    {
        invocou = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (GameObject.Find(playerName) == null && GameObject.Find(playerCloneName) == null)
        {
            if (invocou == false)
            {
                invocou = true;
                Invoke("Renascer", 10);
            }

        }
    }

    void Renascer()
    {
        Instantiate(player,transform.position,transform.rotation);
        mainCamera.transform.position = new Vector3(transform.position.x, 0, -10);
        invocou = false;
    }

}
