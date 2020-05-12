using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class pausescript : MonoBehaviour
{
    public  bool gameispaused = false;
    public GameObject pauseMenuUI;
    public GameObject pauseMenuUI2;
    public GameObject pauseMenuUI3;
    public GameObject pauseMenuUI4;
    // Update is called once per frame
    void Update()
    {

        if (Input.GetKeyDown(KeyCode.Escape))
        {
            hacerlo();
        }
        if (Input.GetButtonDown("pause"))
        //if (Input.GetKeyDown(KeyCode.Escape))

            {
                if (gameispaused)
            {
                Resume();
            }
            else {
                Pausar();
            }

        }
        
    }


    public void hacerlo()
    {
            if (gameispaused)
            {
                Resume();
            }
            else
            {
                Pausar();
            }
    }

    void Resume() {
        pauseMenuUI3.SetActive(true);
        pauseMenuUI2.SetActive(true);
        pauseMenuUI4.SetActive(false);
        pauseMenuUI.SetActive(false);
        Time.timeScale = 1f;
        gameispaused = false;

    }
    void Pausar()
    {
        pauseMenuUI3.SetActive(false);
        pauseMenuUI2.SetActive(false);
        pauseMenuUI4.SetActive(true);
        pauseMenuUI.SetActive(true);
        Time.timeScale = 0f;
        gameispaused = true;
    }
}
