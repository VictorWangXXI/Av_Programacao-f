using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VIda : MonoBehaviour
{
    public int maxVida = 3;
    public int vida;
    public int pontosUnidade;
    public GameObject mainCamera;


    // Start is called before the first frame update
    void Start()
    {
        vida = maxVida;
        pontosUnidade = maxVida;
        mainCamera = GameObject.Find("Main Camera");
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void TakeDamage(int damage)
    {
        vida -= damage;
        if (vida <= 0)
        {
            if (mainCamera.GetComponent<MenuScipt>().gaul == true)
            {
                if (gameObject.tag == "Roman")
                {
                    mainCamera.GetComponent<ContaPontos>().SomaPoints(pontosUnidade);
                }
                else
                {
                    mainCamera.GetComponent<ContaPontos>().SubtraiPoints(pontosUnidade);
                }
            }
            else
            {
                if (gameObject.tag == "Roman")
                {
                    mainCamera.GetComponent<ContaPontos>().SubtraiPoints(pontosUnidade);
                }
                else
                {
                    mainCamera.GetComponent<ContaPontos>().SomaPoints(pontosUnidade);
                }
            }

            Destroy(gameObject);
            
        }
    }


}
