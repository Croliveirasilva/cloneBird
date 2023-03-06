using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spaw : MonoBehaviour
{
    public GameObject pipe;

    public float height;

    public float timerMax;

    private float timer;

    // Start is called before the first frame update
    void Start()
    {
        GameObject pipeNew = Instantiate(pipe);
        pipeNew.transform.position = transform.position + new Vector3(0,Random.Range(-height, height) ,0);
        
    }

    // Update is called once per frame
    void Update()
    {
        if(timer > timerMax){
        GameObject pipeNew = Instantiate(pipe);
        pipeNew.transform.position = transform.position + new Vector3(0,Random.Range(-height, height) ,0);
        Destroy(pipeNew, 20f);
        timer =0;
        }

        timer += Time.deltaTime;
        
    }
}
