using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class GameManager : MonoBehaviour
{




    public static GameManager Instance;

    public Text roundText;
    public Text trialText;
    public Text scoreText;

    public int curLevelCount = 1;
    public int trialCount = 2;
    public int curLevelTargetScore = 2;
    public int curLevelScore = 0;



    public void AddScore()
    {
        curLevelScore++;
        ShowScoreText();
    }

    
    public void ShowRoundText()
    {
        roundText.text = "Round:" + curLevelCount.ToString();
    }
    public void ShowTrialText()
    {

        trialText.text = "Trial:" + trialCount.ToString();
    }

    public void ShowScoreText()
    {

        scoreText.text ="Score:" +(curLevelScore * 100).ToString()+"/"+ 
            (curLevelTargetScore * 100).ToString();
    }
    private void Awake()
    {
        curLevelCount = 1;
        curLevelTargetScore = 2;
        curLevelScore = 0;
        Instance = this;
    }



    public void JudgeWinOrLose()
    {

        switch (curLevelCount) {

            case 1:
                
                //ʧ��
                if (curLevelScore < 2)
                {
                    //���¿�ʼ
                    //��ʼ������
                    curLevelCount = 1;
                    trialCount = 2;
                    curLevelTargetScore = 2;
                    curLevelScore = 0;
                    //���µ���UFO���ɺ���
                    Launcher.Instance.FireUFO();
                    ShowAllText();
                }
                //ʤ��
                else
                {
                    curLevelCount = 2;
                    trialCount = 3;
                    curLevelTargetScore = 3;
                    curLevelScore = 0;
                    //����UFO���ɺ���
                    Launcher.Instance.FireUFO();
                    ShowAllText();

                }
                break;
            case 2:
                //ʧ��
                if (curLevelScore < 3)
                {
                    //���¿�ʼ
                    //��ʼ������
                    curLevelCount = 2;
                    trialCount = 3;
                    curLevelTargetScore = 3;
                    curLevelScore = 0;
                    //���µ���UFO���ɺ���
                    Launcher.Instance.FireUFO();
                    ShowAllText();
                }
                //ʤ��
                else
                {
                    curLevelCount = 3;
                    trialCount = 4;
                    curLevelTargetScore = 4;
                    curLevelScore = 0;
                    //����UFO���ɺ���
                    Launcher.Instance.FireUFO();
                    ShowAllText();
                }
                break;
            case 3:
                //ʧ��
                if (curLevelScore < 4)
                {
                    //���¿�ʼ
                    //��ʼ������
                    curLevelCount = 3;
                    trialCount = 4;
                    curLevelTargetScore = 4;
                    curLevelScore = 0;
                    //����UFO���ɺ���
                    Launcher.Instance.FireUFO();
                    ShowAllText();
                }
                //ʤ��
                else
                {
                    //����1��ѭ��
                    curLevelCount = 1;
                    trialCount = 2;
                    curLevelTargetScore = 2;
                    curLevelScore = 0;
                    //���µ���UFO���ɺ���
                    Launcher.Instance.FireUFO();
                    ShowAllText();
                }
                break;
                

        }


    }





    public void ShowAllText()
    {

        ShowRoundText();
        ShowTrialText();
        ShowScoreText();

    }







}
