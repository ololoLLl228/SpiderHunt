using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class BonusCollisionS : MonoBehaviour
{
    [SerializeField]private Text txt;
    [SerializeField] private Canvas textUp;
    private PlayerMovementAndroid player;
    private Score score;

    private void Start()
    {
        txt = GameObject.FindGameObjectWithTag("DamageText").GetComponent<Text>();
        player = GameObject.FindGameObjectWithTag("Player").GetComponent<PlayerMovementAndroid>();
        score = GameObject.FindGameObjectWithTag("Score").GetComponent<Score>();


    }
    private void OnTriggerEnter(Collider other)
    {
        if(other.tag == "Player")
        {
            
            if(FindObjectOfType<GameManager>().gameHasEnded)
            {
                return;
            }
            score.currentScore += 10;
            score.currentScoreText.text = "Damage for this level: " + score.currentScore.ToString("0");
            if(SceneManager.GetActiveScene().buildIndex == 1)
            {

                if(score.currentScore > PlayerPrefs.GetFloat("MaximumScoreLevel1"))
                {
                    PlayerPrefs.SetFloat("MaximumScoreLevel1", score.currentScore);
                    player.damage += 10;
                    Instantiate(textUp, transform.position, Quaternion.identity);
                    score.MaxDamagePlus += 10;
                }
                score.maxScoreText.text = "Maximum damage for this level: " + PlayerPrefs.GetFloat("MaximumScoreLevel1");

            }
            else if(SceneManager.GetActiveScene().buildIndex == 2)
            {
                if (score.currentScore > PlayerPrefs.GetFloat("MaximumScoreLevel2"))
                {
                    PlayerPrefs.SetFloat("MaximumScoreLevel2", score.currentScore);
                    player.damage += 10;
                    Instantiate(textUp, transform.position, Quaternion.identity);
                    score.MaxDamagePlus += 10;
                }
                score.maxScoreText.text = "Maximum damage for this level: " + PlayerPrefs.GetFloat("MaximumScoreLevel2");
            }
            else if(SceneManager.GetActiveScene().buildIndex == 3)
            {
                if (score.currentScore > PlayerPrefs.GetFloat("MaximumScoreLevel3"))
                {
                    PlayerPrefs.SetFloat("MaximumScoreLevel3", score.currentScore);
                    player.damage += 10;
                    Instantiate(textUp, transform.position, Quaternion.identity);
                    score.MaxDamagePlus += 10;
                }
                score.maxScoreText.text = "Maximum damage for this level: " + PlayerPrefs.GetFloat("MaximumScoreLevel3");
            }
            else if (SceneManager.GetActiveScene().buildIndex == 5)
            {
                if (score.currentScore > PlayerPrefs.GetFloat("MaximumScoreLevel5"))
                {
                    PlayerPrefs.SetFloat("MaximumScoreLevel5", score.currentScore);
                    player.damage += 10;
                    Instantiate(textUp, transform.position, Quaternion.identity);
                    score.MaxDamagePlus += 10;
                }
                score.maxScoreText.text = "Maximum damage for this level: " + PlayerPrefs.GetFloat("MaximumScoreLevel5");
            }
            else if (SceneManager.GetActiveScene().buildIndex == 6)
            {
                if (score.currentScore > PlayerPrefs.GetFloat("MaximumScoreLevel6"))
                {
                    PlayerPrefs.SetFloat("MaximumScoreLevel6", score.currentScore);
                    player.damage += 10;
                    Instantiate(textUp, transform.position, Quaternion.identity);
                    score.MaxDamagePlus += 10;
                }
                score.maxScoreText.text = "Maximum damage for this level: " + PlayerPrefs.GetFloat("MaximumScoreLevel6");
            }
            else if (SceneManager.GetActiveScene().buildIndex == 8)
            {
                if (score.currentScore > PlayerPrefs.GetFloat("MaximumScoreLevel8"))
                {
                    PlayerPrefs.SetFloat("MaximumScoreLevel8", score.currentScore);
                    player.damage += 10;
                    Instantiate(textUp, transform.position, Quaternion.identity);
                    score.MaxDamagePlus += 10;
                }
                score.maxScoreText.text = "Maximum damage for this level: " + PlayerPrefs.GetFloat("MaximumScoreLevel8");
            }
            else if (SceneManager.GetActiveScene().buildIndex == 9)
            {
                if (score.currentScore > PlayerPrefs.GetFloat("MaximumScoreLevel9"))
                {
                    PlayerPrefs.SetFloat("MaximumScoreLevel9", score.currentScore);
                    player.damage += 10;
                    Instantiate(textUp, transform.position, Quaternion.identity);
                    score.MaxDamagePlus += 10;
                }
                score.maxScoreText.text = "Maximum damage for this level: " + PlayerPrefs.GetFloat("MaximumScoreLevel9");
            }
            else if (SceneManager.GetActiveScene().buildIndex == 10)
            {
                if (score.currentScore > PlayerPrefs.GetFloat("MaximumScoreLevel10"))
                {
                    PlayerPrefs.SetFloat("MaximumScoreLevel10", score.currentScore);
                    player.damage += 10;
                    Instantiate(textUp, transform.position, Quaternion.identity);
                    score.MaxDamagePlus += 10;
                }
                score.maxScoreText.text = "Maximum damage for this level: " + PlayerPrefs.GetFloat("MaximumScoreLevel10");
            }
            txt.text = "damage: " + player.damage.ToString();
            Destroy(gameObject);
        }
    }
    
}
