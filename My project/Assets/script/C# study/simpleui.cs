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

    // 멤버 변수
    int currentDday = 1;
    string curretItem = "롱소드";
    int result = 1000;

    float seconds;
    float minutes;
    float hours;

    // Start is called before the first frame update
    void Start()            // 게임이 시작될 때 한번만 선언되는 함수
    {
        NextDday(9);
        ddaytxt.text = "D-day " + currentDday;
        ddayvalue.text = "1";
        iteminfo.text = "아이템 정보";
        income.text = "금일 정산";
        
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
        Debug.Log($"현재 초 : {seconds}");

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

        Debug.Log($"현재 시간 : {hours}" + minutes);
    }
}
