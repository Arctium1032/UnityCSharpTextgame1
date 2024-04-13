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
        
    }

    

    void NextDday(int time)
    {
        currentDday = currentDday + time;
    }
}
