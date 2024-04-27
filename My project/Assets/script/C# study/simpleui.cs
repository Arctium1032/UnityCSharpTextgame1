using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class simpleui : MonoBehaviour
{
    
    public TextMeshProUGUI ddaytxt;
    public TextMeshProUGUI ddayvalue;
    public TextMeshProUGUI income;
    public TextMeshProUGUI iteminfo;
    public TextMeshProUGUI timetext;

    // ��� ����
    int currentDday = 1;
    string curretItem = "�ռҵ�";
    int result = 1000;

    float seconds;
    float minutes;
    float hours;

    // Start is called before the first frame update
    void Start()            // ������ ���۵� �� �ѹ��� ����Ǵ� �Լ�
    {
        NextDday(9);
        ddaytxt.text = "D-day " + currentDday;
        ddayvalue.text = "1";
        iteminfo.text = "������ ����";
        income.text = "���� ����";
        
    }

    // Update is called once per frame
    void Update()
    {
        FlowTime();

        timetext.text = $"{hours}:{minutes}:{seconds}";
    }

    

    void NextDday(int time)
    {
        currentDday = currentDday + time;
    }

    void FlowTime()
    {
        seconds += Time.deltaTime;
        Debug.Log($"���� �� : {seconds}");

        if(seconds >= 60)
        {
            minutes++;
            seconds = 0;

        }
       

        if(minutes >= 60) 
        {
            hours++;
            minutes = 0;
        }

        Debug.Log($"���� �ð� : {hours}" + minutes);
    }
}
