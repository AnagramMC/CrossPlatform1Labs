﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    int _score;
    int _lives;

    public int maxLives;

    // Start is called before the first frame update
    void Start()
    {
        lives = 3;
    }

    // Update is called once per frame
    void Update()
    {
    }

    public int score
    {
        get { return _score; }
        set
        {
            _score = value;
            Debug.Log("Score is changed to " + _score);
        }
    }

    public int lives
    {
        get { return _lives; }
        set
        {
            _lives = value;
            if (_lives > maxLives)
                _lives = maxLives;

            Debug.Log("Lives is changed to " + _lives);
        }
    }
}
