using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TourchLogic : MonoBehaviour
{
    [SerializeField] GameObject no;
    public void toerch()
    {
        if (Playerdata.stone >= 500)
        {
            Playerdata.stone -= 500;
            Playerdata.feigh += 20;
            no.SetActive(false);
        }
        else
        {
            no.SetActive(true);
        }
    }
    
    
}
