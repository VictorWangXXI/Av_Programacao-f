using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Cronometro : MonoBehaviour
{
    public float tempo;
    public float minutos;
    public float segundos;

    public TextMeshProUGUI tempoTxt;

    // Start is called before the first frame update
    void Start()
    {
        tempo = 120F;
    }

    // Update is called once per frame
    void Update()
    {
        tempo -= Time.deltaTime;
        minutos = Mathf.FloorToInt(tempo / 60);
        segundos = Mathf.FloorToInt(tempo % 60);
        tempoTxt.text = string.Format("{0:00}:{1:00}", minutos, segundos);

        if (tempo <= 0)
        {
            gameObject.GetComponent<MenuScipt>().Perder();
        }
    }
}
