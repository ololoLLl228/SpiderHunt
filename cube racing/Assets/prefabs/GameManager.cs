using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public bool gameHasEnded = false;

    public GameObject completeLevelUI;
    private PlayerMovementAndroid player;
    private Score score;


    private void Start()
    {
        score = GameObject.FindGameObjectWithTag("Score").GetComponent<Score>();
        player = GameObject.FindGameObjectWithTag("Player").GetComponent<PlayerMovementAndroid>();
    }
    public void CompleteLevel()
    {
        completeLevelUI.SetActive(true) ;
    }
    public void LoadNextLevel()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
    public void RestartLevel()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
    public void LoadMenu()
    {
        SceneManager.LoadScene("MainMenu");
    }
    public void EndGame()
    {
        if(gameHasEnded == false)
        {
            gameHasEnded = true;
            Invoke("Restart", 2f);
            if(SceneManager.GetActiveScene().buildIndex == 1)
            {
                PlayerPrefs.SetFloat("MaximumScoreLevel1", PlayerPrefs.GetFloat("MaximumScoreLevel1") - score.MaxDamagePlus);
            }
            else if (SceneManager.GetActiveScene().buildIndex == 2)
            {
                PlayerPrefs.SetFloat("MaximumScoreLevel2", PlayerPrefs.GetFloat("MaximumScoreLevel2") - score.MaxDamagePlus);
            }
            else if (SceneManager.GetActiveScene().buildIndex == 3)
            {
                PlayerPrefs.SetFloat("MaximumScoreLevel3", PlayerPrefs.GetFloat("MaximumScoreLevel3") - score.MaxDamagePlus);
            }
            else if (SceneManager.GetActiveScene().buildIndex == 5)
            {
                PlayerPrefs.SetFloat("MaximumScoreLevel5", PlayerPrefs.GetFloat("MaximumScoreLevel5") - score.MaxDamagePlus);
            }
            else if (SceneManager.GetActiveScene().buildIndex == 6)
            {
                PlayerPrefs.SetFloat("MaximumScoreLevel6", PlayerPrefs.GetFloat("MaximumScoreLevel6") - score.MaxDamagePlus);
            }
            else if (SceneManager.GetActiveScene().buildIndex == 7)
            {
                PlayerPrefs.SetFloat("MaximumScoreLevel7", PlayerPrefs.GetFloat("MaximumScoreLevel7") - score.MaxDamagePlus);
            }
            else if (SceneManager.GetActiveScene().buildIndex == 8)
            {
                PlayerPrefs.SetFloat("MaximumScoreLevel8", PlayerPrefs.GetFloat("MaximumScoreLevel8") - score.MaxDamagePlus);
            }
            else if (SceneManager.GetActiveScene().buildIndex == 9)
            {
                PlayerPrefs.SetFloat("MaximumScoreLevel9", PlayerPrefs.GetFloat("MaximumScoreLevel9") - score.MaxDamagePlus);
            }
            else if (SceneManager.GetActiveScene().buildIndex == 10)
            {
                PlayerPrefs.SetFloat("MaximumScoreLevel10", PlayerPrefs.GetFloat("MaximumScoreLevel10") - score.MaxDamagePlus);
            }
        }
    }
    void Restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
