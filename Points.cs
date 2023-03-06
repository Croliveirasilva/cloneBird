using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Points : MonoBehaviour
{

    public gameController _controller;

    void Start(){
        _controller = FindObjectOfType<gameController>();
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        _controller.Score++;
        _controller.textScore.text = _controller.Score.ToString();

    }
}
