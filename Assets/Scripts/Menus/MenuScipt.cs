using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MenuScipt : MonoBehaviour
{

    public GameObject pauseText;
    public GameObject restartButton;
    public GameObject continueButton;
    public GameObject startButton;
    public GameObject winText;
    public GameObject loseText;
    public GameObject quitButton;
    public GameObject tutorialButton;
    public GameObject conjSelecao;
    public GameObject conjSelecaoRoman;
    public GameObject conjEscolhaLado;
    public GameObject tutorialWindow;
    public bool gaul;

    // Start is called before the first frame update
    void Start()
    {
        transform.position = new Vector3(-19, 0, -10);
        Time.timeScale = 0;
        startButton.gameObject.SetActive(true);
        quitButton.gameObject.SetActive(true);
        tutorialButton.gameObject.SetActive(true);
        pauseText.gameObject.SetActive(false);
        restartButton.gameObject.SetActive(false);
        continueButton.gameObject.SetActive(false);
        conjSelecao.gameObject.SetActive(false);
        conjSelecaoRoman.gameObject.SetActive(false);
        conjEscolhaLado.SetActive(false);
        tutorialWindow.gameObject.SetActive(false);

}

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.P))
        {
            if (Time.timeScale == 1)
            {
                pauseText.gameObject.SetActive(true);
                restartButton.gameObject.SetActive(true);
                continueButton.gameObject.SetActive(true);
                quitButton.gameObject.SetActive(true);
                conjSelecao.gameObject.SetActive(false);
                conjSelecaoRoman.gameObject.SetActive(false);
                Time.timeScale = 0;
            }
        }
    }

    public void Iniciar()
    {
        startButton.gameObject.SetActive(false);
        quitButton.gameObject.SetActive(false);
        winText.gameObject.SetActive(false);
        loseText.gameObject.SetActive(false);
        tutorialButton.gameObject.SetActive(false);
        conjEscolhaLado.gameObject.SetActive(true);
    }

    public void EscolheGaul()
    {
        gaul = true;
        conjEscolhaLado.gameObject.SetActive(false);
        conjSelecao.gameObject.SetActive(true);
        Time.timeScale = 1;
        transform.position = new Vector3(-36, 0, -10);
    }

    public void EscolheRoman()
    {
        gaul = false;
        conjEscolhaLado.gameObject.SetActive(false);
        conjSelecaoRoman.gameObject.SetActive(true);
        Time.timeScale = 1;
        transform.position = new Vector3(1, 0, -10);
    }

    public void TutorialOpen()
    {
        startButton.gameObject.SetActive(false);
        quitButton.gameObject.SetActive(false);
        tutorialButton.gameObject.SetActive(false);
        tutorialWindow.gameObject.SetActive(true);
    }
    public void TutorialClose()
    {
        tutorialWindow.gameObject.SetActive(false);
        startButton.gameObject.SetActive(true);
        quitButton.gameObject.SetActive(true);
        tutorialButton.gameObject.SetActive(true);
    }

    public void Continue()
    {
        pauseText.gameObject.SetActive(false);
        continueButton.gameObject.SetActive(false);
        restartButton.gameObject.SetActive(false);
        quitButton.gameObject.SetActive(false);
        if (gaul == true)
        {
            conjSelecao.gameObject.SetActive(true);
        }
        else
        {
            conjSelecaoRoman.gameObject.SetActive(true);
        }

        Time.timeScale = 1;
    }

    public void CallQuit()
    {
        Application.Quit();
    }

    public void Ganhar()
    {
        Time.timeScale = 0;
        winText.gameObject.SetActive(true);
        restartButton.gameObject.SetActive(true);
        quitButton.gameObject.SetActive(true);
        conjSelecao.gameObject.SetActive(false);
        conjSelecaoRoman.gameObject.SetActive(false);
    }

    public void Perder()
    {
        Time.timeScale = 0;
        loseText.gameObject.SetActive(true);
        restartButton.gameObject.SetActive(true);
        quitButton.gameObject.SetActive(true);
        conjSelecao.gameObject.SetActive(false);
        conjSelecaoRoman.gameObject.SetActive(false);
    }
}
