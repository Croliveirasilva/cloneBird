using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bird : MonoBehaviour
{

        public float speed = 1f;
        private Rigidbody2D rig;

        public gameController controller;
        public AudioSource voo;

    
    // Start is called before the first frame update
    void Start()
    {
        rig = GetComponent<Rigidbody2D>();
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetMouseButtonDown(0)){
            rig.velocity = Vector2.up * speed;
            voo.Play();
        }
        
    }


    private void OnCollisionEnter2D(Collision2D other)
    {
        controller.GameOver();
        //Time.timeScale = 0;
        //painelGameOver.SetActive(true);
        
    }
}
