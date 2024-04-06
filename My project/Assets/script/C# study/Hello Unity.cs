using UnityEngine;
using TMPro;


public class HelloUnity : MonoBehaviour
{
    public TMPro.TextMeshProUGUI text; // 데이터 타입인지 모르겠지만 사용하기 위해서 text이름의 변수로 지정

    int damage = 100;           // 정수값
    float time = 12.4f;         // 실수값
    string name = "주인공";     // 문자열 값

    private void Start() // 게임 시작 후 한번만 실행
    {
        Debug.Log("데미지의 값" + damage);
        Debug.Log("시간의 값" + time);
        Debug.Log("이름" + name);


        text.text = string.Format($"Only {damage} english {time} is visible? : 정말이니 ?"); // 갈길이 멀다
    }

}

