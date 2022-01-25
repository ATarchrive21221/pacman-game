using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameController : MonoBehaviour
{
    public GameObject Ghost;
    
    public Text timerText;
    public int count;
    public int countDown;
    public float timeLeft;
    public bool gameStart = true;
    public float Uptime;
    public bool timerGoing = false;
    public int i;
    float t;
    public Text restartText;
    // Start is called before the first frame update
    void Start()
    {
        //note ghost was the name of my public variable that 
        //contains the Ghost prefab
       
           
        Uptime = Time.time;
        float k = 0f;
        k += Time.time;
        restartText.text = "";

    }

    void SpawnGhost()
    {
        Instantiate(Ghost, new Vector3(0f, 0f, 0f), Quaternion.identity);
    }
    

    void StartGame()
    {
       
        gameStart = true;
      
}

    // Update is called once per frame
    void Update()
    {
        t = Time.time - Uptime;
        
        string minutes = ((int)t / 60).ToString();
        string seconds = (t % 60).ToString("f0");
        timerText.text = minutes + ":" +  seconds;
        
        if (Time.time > i)
        {
            i += 5;
            Instantiate(Ghost, new Vector3(0f, 0f, 0f), Quaternion.identity);
        }
        if (Input.GetKeyDown(KeyCode.R))
        {
            RestartGame();
        }

        if (Input.GetKeyDown(KeyCode.P))
        {
            QuitGame();
        }
    }

   public void GameOver()
    {
        
            if (t>0){
            restartText.text = "Game's Over, press R to restart. Your Score is: "+ t;
        }
            

        gameStart = false;
    }
    void RestartGame()
    {
        SceneManager.LoadScene("PacManTag");
    }
    void QuitGame()
    {
        Application.Quit();
    }
   

}
