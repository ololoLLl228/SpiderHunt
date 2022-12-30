using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class LevelSelectorS : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField] private GameObject level2;
    [SerializeField] private GameObject level3;
    [SerializeField] private GameObject level4;
    [SerializeField] private GameObject level5;
    [SerializeField] private GameObject level6;
    [SerializeField] private GameObject level7;
    [SerializeField] private GameObject level8; 
    [SerializeField] private GameObject level9;
    [SerializeField] private GameObject level10;
    void Start()
    {

        if(PlayerPrefs.GetFloat("PermissionToLevel2") == 0f)
        {
            level2.SetActive(false);
        }
        if(PlayerPrefs.GetFloat("PermissionToLevel3") == 0f)
        {
            level3.SetActive(false);
        }
        if(PlayerPrefs.GetFloat("PermissionToLevel4") == 0f)
        {
            level4.SetActive(false);
        }
        if(PlayerPrefs.GetFloat("PermissionToLevel5") == 0f)
        {
            level5.SetActive(false);
        }
        if (PlayerPrefs.GetFloat("PermissionToLevel6") == 0f)
        {
            level6.SetActive(false);
        }
        if (PlayerPrefs.GetFloat("PermissionToLevel7") == 0f)
        {
            level7.SetActive(false);
        }
        if (PlayerPrefs.GetFloat("PermissionToLevel8") == 0f)
        {
            level8.SetActive(false);
        }
        if (PlayerPrefs.GetFloat("PermissionToLevel9") == 0f)
        {
            level9.SetActive(false);
        }
        if (PlayerPrefs.GetFloat("PermissionToLevel10") == 0f)
        {
            level10.SetActive(false);
        }

    }

    // Update is called once per frame
    public void OpenScene1()
    {
        SceneManager.LoadScene(1);
    }
    public void OpenScene2()
    {
        SceneManager.LoadScene(2);
    }
    public void OpenScene3()
    {
        SceneManager.LoadScene(3);
    }
    public void OpenScene4()
    {
        SceneManager.LoadScene(4);
    }
    public void OpenScene5()
    {
        SceneManager.LoadScene(5);
    }
    public void OpenScene6()
    {
        SceneManager.LoadScene(6);
    }
    public void OpenScene7()
    {
        SceneManager.LoadScene(7);
    }
    public void OpenScene8()
    {
        SceneManager.LoadScene(8);
    }
    public void OpenScene9()
    {
        SceneManager.LoadScene(9);
    }
    public void OpenScene10()
    {
        SceneManager.LoadScene(10);
    }
    
    public void ZeroScorePrefs()
    {
        PlayerPrefs.SetFloat("MaximumScoreLevel1", 0);
        PlayerPrefs.SetFloat("MaximumScoreLevel2", 0);
        PlayerPrefs.SetFloat("MaximumScoreLevel3", 0);
        PlayerPrefs.SetFloat("MaximumScoreLevel5", 0);
        PlayerPrefs.SetFloat("MaximumScoreLevel6", 0);
        PlayerPrefs.SetFloat("MaximumScoreLevel8", 0);
        PlayerPrefs.SetFloat("MaximumScoreLevel9", 0);

    }
    public void MaxScorePrefs()
    {
        PlayerPrefs.SetFloat("MaximumScoreLevel1", 1200);
        PlayerPrefs.SetFloat("PermissionToLevel10", 1f);
        PlayerPrefs.SetFloat("PermissionToLevel9", 1f);
        PlayerPrefs.SetFloat("PermissionToLevel8", 1f);
        PlayerPrefs.SetFloat("PermissionToLevel7", 1f);
        PlayerPrefs.SetFloat("PermissionToLevel6", 1f);
        PlayerPrefs.SetFloat("PermissionToLevel5", 1f);
        PlayerPrefs.SetFloat("PermissionToLevel4", 1f);
        PlayerPrefs.SetFloat("PermissionToLevel3", 1f);
        PlayerPrefs.SetFloat("PermissionToLevel2", 1f);
    }
}
