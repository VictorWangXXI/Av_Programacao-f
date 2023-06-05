using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LancarArpao : MonoBehaviour
{
    public GameObject spawn;
    public GameObject arpaoGaul;
    public GameObject arpaoButton;
    

    public void LancaArpao()
    {
        spawn = gameObject.GetComponent<SpanwControl>().selectedSpanw;
        Instantiate(arpaoGaul, spawn.transform.position, new Quaternion(0,0,0,0));
        StartCoroutine(EsperaArpao());
    }
    IEnumerator EsperaArpao()
    {
        arpaoButton.SetActive(false);
        yield return new WaitForSeconds(15f);
        arpaoButton.SetActive(true);
    }
}
