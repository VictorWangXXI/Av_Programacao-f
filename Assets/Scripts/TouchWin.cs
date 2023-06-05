using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TouchWin : MonoBehaviour
{
    public GameObject mainCamera;

    private void OnCollisionEnter2D(Collision2D collision)
    {
        mainCamera.GetComponent<MenuScipt>().Ganhar();
    }


}