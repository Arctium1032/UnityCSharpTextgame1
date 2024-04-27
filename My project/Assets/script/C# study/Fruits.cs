using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fruits : Goods
{
    protected virtual void Start()
    {
         name = $"과일의 이름 : {name}";
         price = $"가격 : {price}";
         description = $"상품 설명 : {description}";
    }

    public interface IExpired
    {
        void Rotted(); // 과일이 썩었을 때
    }
}

