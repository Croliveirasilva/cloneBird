using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class gameController : MonoBehaviour
{
    public GameObject painelStart;
    public GameObject painelGameOver;
    public GameObject painelScore;
    public int Score;
    public Text textScore; 
    // Start is called before the first frame update
    void Start()
    {
        Time.timeScale = 0;
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void IniciaGame(){

        painelGameOver.SetActive(false);

        painelStart.SetActive(false);

        painelScore.SetActive(true);
        

        Time.timeScale = 1;

    }

    public void GameOver(){

         Time.timeScale = 0;
          painelGameOver.SetActive(true);

    }

    public void StartGameOver(){
        SceneManager.LoadScene(0);
        IniciaGame();
      
    }

}
