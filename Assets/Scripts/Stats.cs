using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Stats : MonoBehaviour
{
    public TextMeshProUGUI scoreText;
    public TextMeshProUGUI timerText;
    //public GameObject gameOver;

    public int score;
    public float timer;

    // Start is called before the first frame update
    void Start()
    {
        score = 0;
        timer = 60;
    }

    // Update is called once per frame
    void Update()
    {
        Timer();
    }

    private void Timer()
    {
        if (timer > 0)
        {
            timer -= Time.deltaTime;
            Mathf.RoundToInt(timer);
        }
        else
        {
            //GameOver();
            Debug.Log("over");
        }
    }

    public void AddScore(int add)
    {
        score += score + add;
    }

    /*private void GameOver()
    {
        gameOver.SetActive(true);
    }*/
}
