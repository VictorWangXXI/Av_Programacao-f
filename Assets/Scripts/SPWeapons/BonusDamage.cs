using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class BonusDamage : MonoBehaviour
{
    public float duracao = 6f;
    public GameObject bonusButton;
    public float timePassed = 0;
    public GameObject player;

    private void Start()
    {
        //bonusButton = GameObject.Find("BonusButton");
    }
    private void Update()
    {
        timePassed = timePassed + Time.deltaTime;
        if (player == null)
        {
            StopCoroutine(TempoDeBonus());
        }
    }

    

    public void AumentarDano()
    {
        if (player == null)
        {
            player = GameObject.Find("RomanPlayer(Clone)"); 
            if(player != null)
            {
                StartCoroutine(TempoDeBonus());
                StartCoroutine(EsperaBonus());
            }
        }
        else
        {
            StartCoroutine(TempoDeBonus());
            StartCoroutine(EsperaBonus());
        }

        return;
    }
    IEnumerator TempoDeBonus()
    {
        player.GetComponent<Atacar>().dano = 2;
        player.GetComponent<SpriteRenderer>().color = Color.red;
        yield return new WaitForSeconds(duracao);
        if (player == null)
        {
            yield break;
        }
        player.GetComponent<Atacar>().dano = 1;
        player.GetComponent<SpriteRenderer>().color = Color.white;
    }
    IEnumerator EsperaBonus()
    {
        bonusButton.SetActive(false);
        yield return new WaitForSeconds(15f);
        bonusButton.SetActive(true);
    }

}
