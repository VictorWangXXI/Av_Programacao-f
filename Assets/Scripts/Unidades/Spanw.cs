using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spanw : MonoBehaviour
{
    public GameObject[] inimigo;
    private float timer;
    public float timerInimigo = 4f;
    public int inimigoIndex;

    public GameObject[] spawner;
    public int spawnerIndex;

    // Start is called before the first frame update
    void Start()
    {
        timer = 1;
    }

    // Update is called once per frame
    void Update()
    {
        timer = timer - Time.deltaTime;
        if(timer<=0)
        {
            inimigoIndex = Random.Range(0, 3);
            spawnerIndex = Random.Range(0, 3);
            Instantiate(inimigo[inimigoIndex], spawner[spawnerIndex].transform.position, spawner[spawnerIndex].transform.rotation);
            timer = timerInimigo;
        }

    }
}
