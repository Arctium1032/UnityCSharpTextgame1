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
    int currentDday = 1;
    
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
        
    }

    

    void NextDday(int time)
    {
        currentDday = currentDday + time;
    }
}
