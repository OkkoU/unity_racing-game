using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public GameObject gameOver;


    void Start()
    {
        gameOver.SetActive(false);

        Time.timeScale = 1f;
    }


    public void Pause()
    {
        Time.timeScale = 0f;
    }


    public void GameOver()
    {
        gameOver.SetActive(true);

        Pause();
    }
}
