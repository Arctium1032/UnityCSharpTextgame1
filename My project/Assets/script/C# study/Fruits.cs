using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fruits : Goods
{
    protected virtual void Start()
    {
         name = $"������ �̸� : {name}";
         price = $"���� : {price}";
         description = $"��ǰ ���� : {description}";
    }

    public interface IExpired
    {
        void Rotted(); // ������ ����� ��
    }
}

