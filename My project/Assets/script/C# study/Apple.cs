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
        name = "»ç°ú";
        price = "1000";
        description = "»¡°²´Ù";
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
