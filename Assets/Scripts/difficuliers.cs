using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//using random;

public class difficuliers : MonoBehaviour
{
    [SerializeField] GameObject event_1_o, event_2_o, event_3_o;
    public void event_1_1()
    {
        Playerdata.population_day -= 20;
        Playerdata.population -= 500;
        
        event_1_o.SetActive(false);

    }
    public void event_1_2()
    {
        Playerdata.weapon -= 200;
        Playerdata.weapon_day -= 20;
        Playerdata.population_day -= 20;
        Playerdata.food_day -= 20;
        Playerdata.stone_day -= 20;
        Playerdata.stone -= 100;
        Playerdata.population -= 100;
        event_1_o.SetActive(false);

    }
    public void event_1_3()
    {
        Playerdata.weapon += 100;
        Playerdata.stone += 200;
        Playerdata.food += 200;
        Playerdata.population -= 1000;
        Playerdata.population_day -= 100;
        
        event_1_o.SetActive(false);

    }


    public void event_2()
    {

        event_2_o.SetActive(false);
        Playerdata.attak += 5;

    }

    public void event_3_food()
    {
        event_3_o.SetActive(false);
        Playerdata.food -= 100;
        Playerdata.population -= 500;
    }

    public void event_3_people()
    {
        event_3_o.SetActive(false);
        Playerdata.food -= 500;
        Playerdata.population -= 100;
    }

    
    
}
