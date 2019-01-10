using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class scoreManager : MonoBehaviour
{   
    public static scoreManager ScoreManager;

    public Text scoreText;
    int score = 0;

    void Start()
    {
        if(ScoreManager == null)
        {
            ScoreManager = this;
            DontDestroyOnLoad(this);
        }
        else
        {
            Destroy(gameObject);
        }
        
    }

    void Update()
    {
        if(scoreText == null)
        {
            scoreText = GameObject.Find("Text").GetComponent<Text>();
            scoreText.text = score + "";
        }   
    }

    public void RaiseScore(int s)
    {
        score += s;
        scoreText.text = score + "";

        if (score == 3)
        {
            SceneManager.LoadScene("scene2");
        }
    }
}
