using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArcherAtk : MonoBehaviour
{
    public float speed;

    public Animator anim;

    public GameObject rangeDetector;
    public GameObject firingPoint;
    public string enemyTag;

    public int dano;
    public float tempoAtaque;

    public bool attacking;


    private float timerAttack = 0f;

    // Start is called before the first frame update
    void Awake()
    {
        attacking = false;
        timerAttack = 0;
        anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {

        if (attacking == false)
        {
            transform.Translate(Vector3.left * Time.deltaTime * speed);
            anim.SetBool("Run", true);
        }
    }


    public void TriggerAttack(Collider2D collision)
    {
        if (collision.gameObject.tag == enemyTag)
        {
            timerAttack = timerAttack - Time.deltaTime;
            anim.SetBool("Run", false);
            attacking = true;
            if (timerAttack <= 0)
            {
                anim.SetTrigger("Attack");
                firingPoint.GetComponent<ArcherFire>().DispararFlecha();
                timerAttack = tempoAtaque;
            }
        }
    }

}
