using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class InstructionGetActiveS : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField] private Text englishText;
    [SerializeField] private Text ukrainianText;
    [SerializeField] private Button englishButt;
    [SerializeField] private Button ukrainianButt;


    private void Start()
    {
        ukrainianText.gameObject.SetActive(true);
        englishText.gameObject.SetActive(false);
        ukrainianButt.gameObject.SetActive(false);
        englishButt.gameObject.SetActive(true);
    }
    public void Active()
    {
        gameObject.SetActive(true) ;
    }
    public void Disactive()
    {
        gameObject.SetActive(false);
    }
    public void EnglishActive()
    {
        englishText.gameObject.SetActive(true);
        ukrainianText.gameObject.SetActive(false);
        englishButt.gameObject.SetActive(false);
        ukrainianButt.gameObject.SetActive(true);
    }
    public void UkrainianActive()
    {
        englishText.gameObject.SetActive(false);
        ukrainianText.gameObject.SetActive(true);
        englishButt.gameObject.SetActive(true);
        ukrainianButt.gameObject.SetActive(false);
    }
}
