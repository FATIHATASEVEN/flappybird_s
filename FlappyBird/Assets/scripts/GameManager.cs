using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public int score;
    public Text ScoreText;

    void Start()
    {
        score = 0;
        ScoreText.text = score.ToString();
    }
    void Update()
    {
        
    }
    public void Updatescore()
    {
        score++;
        ScoreText.text = score.ToString();

    }  
    public void ReduceScore()
    {
        score--;
        ScoreText.text = score.ToString();
    }
    public void Restart()
    {
        SceneManager.LoadScene(1);
    }
    
}
