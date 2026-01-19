using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;


public class LevelManager : MonoBehaviour
{
    public static LevelManager instance;
    public int playerHealth;
    public int highScore;
    public int playerScore;
    public TMP_Text healthText;

    void Awake()
    {
        if (instance == null)
        {
            // if instance is null, store a reference to this instance
            instance = this;
            DontDestroyOnLoad(gameObject);
            print("do not destroy");
        }
        else
        {
            // Another instance of this gameobject has been made so destroy it
            // as we already have one
            print("do destroy");
            Destroy(gameObject);
        }

        playerHealth = 100;

    }

    private void Update()
    {
        //healthText.text = "Health: " + playerHealth;

        //update player score

        if (playerHealth > 70)
        {
            playerScore = playerScore + 0;
        }



    }


    //these methods are globally accessible
    public void SetHighScore(int score)
    {
        highScore = score;
    }
    public int GetHighScore()
    {
        return highScore;
    }
}