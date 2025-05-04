using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//using random;

public class difficuliers : MonoBehaviour
{
    [SerializeField] GameObject event_1_o, event_2_o;
    public void event_1()
    {
        
        if ((Playerdata.population <= 100) || (Playerdata.population >= 0))
        {
            Playerdata.population = 0;
        }
        else
        {
            Playerdata.population -= 100;
        }
        
        event_1_o.SetActive(false);

    }
    public void event_2()
    {

        event_1_o.SetActive(false);
        Playerdata.attak += 5;

    }

    
    
}
