using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArcherRangeDetection : MonoBehaviour
{
    public GameObject archer;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnTriggerStay2D(Collider2D collision)
    {

            archer.GetComponent<ArcherAtk>().TriggerAttack(collision);

    }

    public void OnTriggerExit2D(Collider2D collision)
    {
        archer.GetComponent<ArcherAtk>().anim.SetBool("Run", true);
        archer.GetComponent<ArcherAtk>().attacking = false;
    }
}
