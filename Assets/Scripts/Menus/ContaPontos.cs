using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ContaPontos : MonoBehaviour
{
    public int pontos;
    public TextMeshProUGUI pontosTxt;

    // Start is called before the first frame update
    void Start()
    {
        pontos = 0;
        SetPointsTxt();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void SomaPoints(int addPontos)
    {
        pontos = pontos + addPontos;
        SetPointsTxt();
    }
    public void SubtraiPoints(int subPontos)
    {
        pontos = pontos - subPontos;
        SetPointsTxt();
    }

    void SetPointsTxt()
    {
        pontosTxt.text = "Pontos: " + pontos.ToString();
    }

}
