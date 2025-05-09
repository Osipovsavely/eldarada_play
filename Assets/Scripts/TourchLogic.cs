using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TourchLogic : MonoBehaviour
{
    
    public void toerch()
    {
        Playerdata.stone -= 500;
        Playerdata.feigh += 20;
    }
}
