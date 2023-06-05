using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class SpanwControl : MonoBehaviour
{
    public GameObject spanw1;
    public GameObject spanw2;
    public GameObject spanw3;
    public GameObject selectedSpanw;
    public TextMeshProUGUI sp1txt;
    public TextMeshProUGUI sp2txt;
    public TextMeshProUGUI sp3txt;
    public TextMeshProUGUI selectedSpTxt;

    public GameObject lanca;
    public GameObject cavalo;
    public GameObject arco;

    public GameObject lancaButton;
    public GameObject cavaloButton;
    public GameObject arcoButton;

    // Start is called before the first frame update
    void Start()
    {
        selectedSpanw = spanw1;
        selectedSpTxt = sp1txt;
        selectedSpTxt.color = Color.red;
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void Select1()
    {
        selectedSpTxt.color = Color.black;
        selectedSpTxt = sp1txt;
        selectedSpanw = spanw1;
        selectedSpTxt.color = Color.red;
    }
    public void Select2()
    {
        selectedSpTxt.color = Color.black;
        selectedSpTxt = sp2txt;
        selectedSpanw = spanw2;
        selectedSpTxt.color = Color.red;
    }
    public void Select3()
    {
        selectedSpTxt.color = Color.black;
        selectedSpTxt = sp3txt;
        selectedSpanw = spanw3;
        selectedSpTxt.color = Color.red;
    }

    public void SpanwLanca()
    {
        Instantiate(lanca, selectedSpanw.transform.position, selectedSpanw.transform.rotation);
        StartCoroutine(EsperaLanca());
    }
    IEnumerator EsperaLanca()
    {
        lancaButton.SetActive(false);
        yield return new WaitForSeconds(5.5f);
        lancaButton.SetActive(true);
    }
    public void SpanwArco()
    {
        Instantiate(arco, selectedSpanw.transform.position, selectedSpanw.transform.rotation);
        StartCoroutine(EsperaArco());
    }
    IEnumerator EsperaArco()
    {
        arcoButton.SetActive(false);
        yield return new WaitForSeconds(6f);
        arcoButton.SetActive(true);
    }

    public void SpanwCavalo()
    {
        Instantiate(cavalo, selectedSpanw.transform.position, selectedSpanw.transform.rotation);
        StartCoroutine(EsperaCavalo());
    }
    IEnumerator EsperaCavalo()
    {
        cavaloButton.SetActive(false);
        yield return new WaitForSeconds(7.5f);
        cavaloButton.SetActive(true);
    }

}
