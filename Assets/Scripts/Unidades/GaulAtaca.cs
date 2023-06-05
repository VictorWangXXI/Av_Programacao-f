using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class GaulAtaca : MonoBehaviour
{
    public float speed;

    public Animator anim;
    public Transform attackPoint;
    public float attackRange = 0.5f;
    public LayerMask romanLayers;

    public int dano;
    public float tempoAtaque=2;

    public bool attacking;


    private float timerAttack = 0f;

    // Start is called before the first frame update
    void Awake()
    {
        attacking = false;
        timerAttack = 0;
    }

    // Update is called once per frame
    void Update()
    {

        transform.Translate(Vector3.left * Time.deltaTime * speed);
        if (attacking == false)
        {
            anim.SetBool("Run", true);
        }
    }


    private void OnCollisionStay2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Roman")
        {
            timerAttack = timerAttack - Time.deltaTime;
            attacking = true;
            if (timerAttack <= 0)
            {
                Attack();
                anim.SetTrigger("Attack");
                timerAttack = tempoAtaque;
            }
        }
    }

    private void OnCollisionExit(Collision collision)
    {
        anim.SetBool("Run", false);
    }


    private void OnCollisionExit2D(Collision2D collision)
    {
        attacking = false;
    }

    void Attack() //Serve para quando vários inimigos estão sobrepostos
    {
        Collider2D[] hitRoman = Physics2D.OverlapCircleAll(attackPoint.position, attackRange, romanLayers);

        foreach (Collider2D roman in hitRoman)
        {
            roman.GetComponent<VIda>().TakeDamage(dano);
        }
    }

}