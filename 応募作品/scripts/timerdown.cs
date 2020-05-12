using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class timerdown : MonoBehaviour
{
    float currentTime = 0f;
    float startingTime = 120f;
    public Text countdown;

    public GameObject pauseMenuUI5;
    public GameObject pauseMenuUI4;
    public GameObject pauseMenuUI3;
    public GameObject pauseMenuUI2;


    void Start()
    {

        currentTime = startingTime;
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        currentTime -= 1 *Time.deltaTime;
        countdown.text = "TIME:"+ currentTime.ToString("0.0");
        if (currentTime <= 0)
        {
            currentTime = 0;
            countdown.text = "TIME:" + currentTime.ToString("0.0");

            pauseMenuUI5.SetActive(true);
            pauseMenuUI4.SetActive(false);
            pauseMenuUI2.SetActive(true);
            pauseMenuUI3.SetActive(false);
            Time.timeScale = 0f;

        }

    }





}
