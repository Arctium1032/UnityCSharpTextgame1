using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Apple : Fruits, Fruits.IExpired

{
    public void Rotted()
    {
        throw new System.NotImplementedException();
    }

    // Start is called before the first frame update
    void InitData()
    {
        name = "���";
        price = "1000";
        description = "������";
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
