using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Atacar : MonoBehaviour
{
    public Animator anim;
    public Transform attackPoint;
    public float attackRange = 0.5f;
    public LayerMask enemyLayers;

    public float attackRate = 3f;
    public float nextAttackTime = 0f;
    public int dano = 1;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Time.time >= nextAttackTime)
        {
            GetComponent<MovePlayer>().atacando = false;
            if (Input.GetKeyDown(KeyCode.Space))
            {
                Attack();
                GetComponent<MovePlayer>().atacando = true;
                nextAttackTime = Time.time + 1f / attackRate;
            }
        }

    }

    void Attack()
    {

        anim.SetTrigger("Attack");

        Collider2D[] hitEnemies = Physics2D.OverlapCircleAll(attackPoint.position, attackRange, enemyLayers);

        foreach (Collider2D enemy in hitEnemies)
        {
            enemy.GetComponent<VIda>().TakeDamage(dano);
        }
    }


    private void OnDrawGizmosSelected()
    {
        if (attackPoint == null) return;
        Gizmos.DrawWireSphere(attackPoint.position, attackRange);
    }

}
