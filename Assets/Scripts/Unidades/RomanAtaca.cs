using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class RomanAtaca : MonoBehaviour
{
    public float speed;

    public Animator anim;
    public Transform attackPoint;
    public float attackRange = 0.5f;
    public LayerMask GaulLayers;

    public int dano;
    public float tempoAtaque;

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
        if (collision.gameObject.tag == "Gaul")
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

    void Attack()
    {
        Collider2D[] hitGaul = Physics2D.OverlapCircleAll(attackPoint.position, attackRange, GaulLayers);

        foreach (Collider2D gaul in hitGaul)
        {
            gaul.GetComponent<VIda>().TakeDamage(dano);
        }
    }

}
