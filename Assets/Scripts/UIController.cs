using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using DG.Tweening;
using TMPro;
using UnityEngine.SceneManagement;

public class UIController : MonoBehaviour
{
    public static UIController instance;
   
    int staminaLvl = 1;
    int speedLvl = 1;
    int incomeLvl = 1;
    int staminaUpgradeMoney;
    int speedUpgradeMoney;
    int incomeUpgradeMoney;
    public bool gameStart = false;
    public GameObject startText;
    public TextMeshProUGUI incomeText;
    public TextMeshProUGUI staminaLvlText;
    public TextMeshProUGUI speedLvlText;
    public TextMeshProUGUI incomeLvlText;
    public TextMeshProUGUI staminaUpgradeMoneyText;
    public TextMeshProUGUI speedUpgradeMoneyText;
    public TextMeshProUGUI incomeUpgradeMoneyText;
    public GameObject staminaIndicator;
    public GameObject speedIndicator;
    public GameObject moneyIndicator;
    public GameObject startPanel;    
    public GameObject PausePanel;
    public GameObject continueButton;
    public GameObject tryAgainButton;

    private void Awake()
    {
        instance = this;
        
        
    }
    void Start()
    {       
       
        
        staminaLvl = PlayerPrefs.GetInt("StaminaLvl");
       
        speedLvl = PlayerPrefs.GetInt("SpeedLvl");
        
        incomeLvl = PlayerPrefs.GetInt("IncomeLvl");
        
        InvokeRepeating("StartTextAnim", 0f,1f);        
        
    }
    private void Update()
    {       
        Income();
        StaminaLvlText();
        SpeedLvlText();
        IncomeLvlText();
        StaminaUpgradeMoney();
        SpeedUpgradeMoney();
        IncomeUpgradeMoney();
        

    }

    void Income()
    {
        incomeText.text =PlayerPrefs.GetInt("Income").ToString();
    }
    void StartTextAnim()
    {
        startText.transform.DOPunchScale(new Vector3(0.3f, 0, 0.3f), 1f, 1, 1);
    }
    public void GameStartPanelButton()
    {
        gameStart = true;
        startPanel.gameObject.SetActive(false);
        staminaIndicator.gameObject.SetActive(false);
        moneyIndicator.gameObject.SetActive(false);
        speedIndicator.gameObject.SetActive(false);

    }
    public void PauseButton()
    {
        

        PausePanel.gameObject.SetActive(true);

    }
    public void ResumeButton()
    {
        Time.timeScale = 1;
        gameStart = true;
        PausePanel.gameObject.SetActive(false);

    }
    public void RestartButton()
    {
        SceneManager.LoadScene(0);
        Time.timeScale = 1;
        Stamina.instance.stamina = PlayerPrefs.GetInt("Stamina");
        PausePanel.gameObject.SetActive(false);
    }
    public void QuitButton()
    {
        Application.Quit();
    }
    public void ResetAllButton()
    {
        SceneManager.LoadScene(0);
        Time.timeScale = 1;
        PausePanel.gameObject.SetActive(false);        
        PlayerPrefs.DeleteAll();
    }
    public void StaminaButton()
    {
        if (PlayerPrefs.GetInt("Income") - staminaUpgradeMoney >= 0)
        {
            
            PlayerPrefs.SetInt("Stamina", PlayerPrefs.GetInt("Stamina")+5);
            staminaLvl++;
            Stamina.instance.stamina = PlayerPrefs.GetInt("Stamina");
            PlayerPrefs.SetInt("StaminaLvl", staminaLvl);
            Money.instance.MoneyDecrease(staminaUpgradeMoney);
        }            

    }
    public void IncomeButton()
    {
        if (PlayerPrefs.GetInt("Income") - incomeUpgradeMoney >= 0)
        {
            incomeLvl++;
            PlayerPrefs.SetInt("IncomeLvl", incomeLvl);
            Money.instance.MoneyDecrease(incomeUpgradeMoney);
        }    

    }
    public void SpeedButton()
    {
        if (PlayerPrefs.GetInt("Income") - speedUpgradeMoney >= 0)
        {
            Speed.instance.SpeedButton();
            speedLvl++;
            PlayerPrefs.SetInt("SpeedLvl", speedLvl);
            Money.instance.MoneyDecrease(speedUpgradeMoney);
        }       

    }
    public void ContinueButton()
    {
        LevelContinue.instance.Continue();
        continueButton.gameObject.SetActive(false);
        tryAgainButton.gameObject.SetActive(false);

    }
    public void DeathPanel()
    {
        continueButton.gameObject.SetActive(true);
        tryAgainButton.gameObject.SetActive(true);

    }
    
    void StaminaLvlText()
    {
        staminaLvlText.text = "LVL:" + staminaLvl;

    }
    void SpeedLvlText()
    {
        speedLvlText.text = "LVL:" + speedLvl;

    }
    void IncomeLvlText()
    {
        incomeLvlText.text = "LVL:" + incomeLvl;

    }
    void StaminaUpgradeMoney()
    {
        
        staminaUpgradeMoney = 40 + (staminaLvl+2)*2;    
       
        staminaUpgradeMoneyText.text = staminaUpgradeMoney.ToString();

    }
    void SpeedUpgradeMoney()
    {
        speedUpgradeMoney = 40 + (speedLvl + 2) * 2;      
        
        speedUpgradeMoneyText.text = speedUpgradeMoney.ToString();

    }
    void IncomeUpgradeMoney()
    {
        
        incomeUpgradeMoney = 40 + ((incomeLvl + 2) * 2);     
       
        incomeUpgradeMoneyText.text = incomeUpgradeMoney.ToString();

    }
}
