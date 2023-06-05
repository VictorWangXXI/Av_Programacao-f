using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArcherFire : MonoBehaviour
{
    public GameObject arrow;
    
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void DispararFlecha()
    {
        StartCoroutine(AtrasoDispararFlecha());

    }
    IEnumerator AtrasoDispararFlecha()
    {
        yield return new WaitForSeconds(0.8f);
        Instantiate(arrow, transform.position, transform.rotation);
    }


}
