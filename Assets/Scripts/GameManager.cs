using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public Button restartButton;
    public bool gameActive;
    public GameObject titleScreen;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    public void StartGame()
    {
        gameActive = true;
        titleScreen.SetActive(false);
    }

    public void GameOver()
    {
        restartButton.gameObject.SetActive(true);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void RestartGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
