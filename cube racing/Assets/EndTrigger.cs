using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class EndTrigger : MonoBehaviour
{

    public GameManager gameManager;
    private PlayerMovementAndroid player;
    [SerializeField] private Text maxScore;
    [SerializeField] private Text currentScore;
    [SerializeField] private Text totalDamage;
    private Score score;
    private void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player").GetComponent<PlayerMovementAndroid>();
        score = GameObject.FindGameObjectWithTag("Score").GetComponent<Score>();
        
    }
    private void OnTriggerEnter(Collider other)
    {
        if(other.tag == "Player")
        {
            gameManager.CompleteLevel();


            
            totalDamage.text = "Total damage: " + player.damage;
            maxScore.text = score.maxScoreText.text;
            currentScore.text = score.currentScoreText.text;
            if(SceneManager.GetActiveScene().buildIndex == 1)
            {
                PlayerPrefs.SetFloat("PermissionToLevel2", 1f);
            }
            else if(SceneManager.GetActiveScene().buildIndex == 2)
            {
                PlayerPrefs.SetFloat("PermissionToLevel3", 1f);
            }
            else if(SceneManager.GetActiveScene().buildIndex == 3)
            {
                PlayerPrefs.SetFloat("PermissionToLevel4", 1f);
            }
            else if(SceneManager.GetActiveScene().buildIndex == 4)
            {
                PlayerPrefs.SetFloat("PermissionToLevel5", 1f);
            }
            else if (SceneManager.GetActiveScene().buildIndex == 5)
            {
                PlayerPrefs.SetFloat("PermissionToLevel6", 1f);
            }
            else if (SceneManager.GetActiveScene().buildIndex == 6)
            {
                PlayerPrefs.SetFloat("PermissionToLevel7", 1f);
            }
            else if (SceneManager.GetActiveScene().buildIndex == 7)
            {
                PlayerPrefs.SetFloat("PermissionToLevel8", 1f);
            }
            else if (SceneManager.GetActiveScene().buildIndex == 8)
            {
                PlayerPrefs.SetFloat("PermissionToLevel9", 1f);
            }
            else if (SceneManager.GetActiveScene().buildIndex == 9)
            {
                PlayerPrefs.SetFloat("PermissionToLevel10", 1f);
            }
        }



    }
}
