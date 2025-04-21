using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UpdateController : MonoBehaviour
{
    //Playerdata.up_stoimost_stone = 20;
    
    public void Update_population()
    {
        if ((Playerdata.stone >= Playerdata.up_stoimost_stone) && (Playerdata.food >= Playerdata.up_stoimost_food) && (Playerdata.population >= Playerdata.up_stoimost_people))
        {
            Playerdata.stone -= Playerdata.up_stoimost_stone;
            Playerdata.food -= Playerdata.up_stoimost_food;
            Playerdata.population -= Playerdata.up_stoimost_people;
            //up_ogran_population = up_ogran_population * 1.1f;
            //Debug.Log(Mathf.Round(up_ogran_population));
            Playerdata.population_day += 5;
            

        }
    }
}
