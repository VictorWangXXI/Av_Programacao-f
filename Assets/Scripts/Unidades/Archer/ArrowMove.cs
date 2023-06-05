using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArrowMove : MonoBehaviour
{
    public float speed;
    public string enemyTag;
    public int arrowDamage;
    private float tempoDeVida;

    // Start is called before the first frame update
    void Start()
    {
        tempoDeVida = 8f;
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.right * Time.deltaTime * speed);
        tempoDeVida -= Time.deltaTime;
        if (tempoDeVida <= 0)
        {
            Destroy(gameObject);
        }
    }

    public void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == enemyTag)
        {
            collision.GetComponent<VIda>().TakeDamage(arrowDamage);
            Destroy(gameObject);
        }

    }

}
