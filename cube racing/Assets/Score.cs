using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Score : MonoBehaviour
{


    private float score;
    public Text currentScoreText;
    public Text maxScoreText;
    [SerializeField] private Text totalDamageText;
    public float currentScore = 0;
    private float totalDamage;
    private PlayerMovementAndroid player;
    private Text damageText;
    public float MaxDamagePlus = 0;
    private void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player").GetComponent<PlayerMovementAndroid>();
        damageText = GameObject.FindGameObjectWithTag("DamageText").GetComponent<Text>();
        player.damage = PlayerPrefs.GetFloat("MaximumScoreLevel1") + PlayerPrefs.GetFloat("MaximumScoreLevel2") + PlayerPrefs.GetFloat("MaximumScoreLevel3") + PlayerPrefs.GetFloat("MaximumScoreLevel5") + PlayerPrefs.GetFloat("MaximumScoreLevel6") + PlayerPrefs.GetFloat("MaximumScoreLevel8") + PlayerPrefs.GetFloat("MaximumScoreLevel9") + PlayerPrefs.GetFloat("MaximumScoreLevel10") ;
        totalDamage = player.damage;
        damageText.text = "damage: " + player.damage.ToString("0");
        currentScoreText.text = "Damage for this level: 0";
        if (SceneManager.GetActiveScene().buildIndex == 1)
        {

            maxScoreText.text = "Maximum damage for this level: " + PlayerPrefs.GetFloat("MaximumScoreLevel1");
        }
        else if (SceneManager.GetActiveScene().buildIndex == 2)
        {
            maxScoreText.text = "Maximum damage for this level: " + PlayerPrefs.GetFloat("MaximumScoreLevel2");
        }
        else if(SceneManager.GetActiveScene().buildIndex == 3)
        {
            maxScoreText.text = "Maximum damage for this level: " + PlayerPrefs.GetFloat("MaximumScoreLevel3");
        }
        else if (SceneManager.GetActiveScene().buildIndex == 4)
        {
            maxScoreText.text = "huy";
        }
        else if (SceneManager.GetActiveScene().buildIndex == 5)
        {
            maxScoreText.text = "Maximum damage for this level: " + PlayerPrefs.GetFloat("MaximumScoreLevel5");
        }
        else if (SceneManager.GetActiveScene().buildIndex == 6)
        {
            maxScoreText.text = "Maximum damage for this level: " + PlayerPrefs.GetFloat("MaximumScoreLevel6");
        }
        else if (SceneManager.GetActiveScene().buildIndex == 7)
        {
            maxScoreText.text = "Maximum damage for this level: " + PlayerPrefs.GetFloat("MaximumScoreLevel7");
        }
        else if (SceneManager.GetActiveScene().buildIndex == 8)
        {
            maxScoreText.text = "Maximum damage for this level: " + PlayerPrefs.GetFloat("MaximumScoreLevel8");
        }
        else if (SceneManager.GetActiveScene().buildIndex == 9)
        {
            maxScoreText.text = "Maximum damage for this level: " + PlayerPrefs.GetFloat("MaximumScoreLevel9");
        }
        else if (SceneManager.GetActiveScene().buildIndex == 10)
        {
            maxScoreText.text = "Maximum damage for this level: " + PlayerPrefs.GetFloat("MaximumScoreLevel10");
        }

    }


}
