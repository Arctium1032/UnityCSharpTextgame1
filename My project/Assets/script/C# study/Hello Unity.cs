using UnityEngine;
using TMPro;


public class HelloUnity : MonoBehaviour
{
    public TMPro.TextMeshProUGUI text; // ������ Ÿ������ �𸣰����� ����ϱ� ���ؼ� text�̸��� ������ ����

    int damage = 100;           // ������
    float time = 12.4f;         // �Ǽ���
    string name = "���ΰ�";     // ���ڿ� ��

    private void Start() // ���� ���� �� �ѹ��� ����
    {
        Debug.Log("�������� ��" + damage);
        Debug.Log("�ð��� ��" + time);
        Debug.Log("�̸�" + name);


        text.text = string.Format($"Only {damage} english {time} is visible? : �����̴� ?"); // ������ �ִ�
    }

}

