using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovePlayer : MonoBehaviour
{
    public float horizontalInput;
    public float verticalInput;
    public float speed = 10.0f;
    public Animator anim;
    public bool correAtivo;
    public bool atacando;

    public float limiteSuperior;
    public float limiteInferior;
    public float limiteDireita;
    public float limiteEsquerdo;

    // Start is called before the first frame update
    void Start()
    {
        anim = gameObject.GetComponent<Animator>();
        atacando = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (atacando == false)
        {
        if (Input.GetKey(KeyCode.D)) 
        { 
            transform.Translate(Vector3.right * Time.deltaTime * -speed);
            transform.rotation = new Quaternion(0, 180, 0, 0);
        }

        if (Input.GetKey(KeyCode.A))
        {
            transform.Translate(Vector3.left * Time.deltaTime * speed);
            transform.rotation = new Quaternion(0, 0, 0, 0);
        }

        horizontalInput = Input.GetAxis("Horizontal");
        verticalInput = Input.GetAxis("Vertical");
        transform.Translate(Vector3.up * Time.deltaTime * verticalInput * speed);

        if (horizontalInput == 0 && verticalInput == 0)
        {
            CorrendoAni(false);
        }
        else
        {
            CorrendoAni(true);
        }
        }

        if (transform.position.y >= limiteSuperior)
        {
            transform.position = new Vector3(transform.position.x, limiteSuperior, 0);
        }
        if (transform.position.y <= limiteInferior)
        {
            transform.position = new Vector3(transform.position.x, limiteInferior, 0);
        }
        if (transform.position.x >= limiteDireita)
        {
            transform.position = new Vector3(limiteDireita, transform.position.y, 0);
        }
        if (transform.position.x <=limiteEsquerdo)
        {
            transform.position = new Vector3(limiteEsquerdo, transform.position.y, 0);
        }




    }

    public void CorrendoAni(bool correndo)
    {
  
        if(correndo==false)
        {
            anim.SetFloat("Run",0);
            correAtivo = false;
        }
        if(correndo == true)
        {
            if(correAtivo == false)
            {
                anim.SetFloat("Run", 1);
                correAtivo = true;
            }
        }
    }
       
}
