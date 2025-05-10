using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UpdateController : MonoBehaviour
{
    //Playerdata.up_stoimost_stone = 20;
    //[SerializeField] TMP_Text res;
    
    public void Update_population()
    {

        if ((Playerdata.rescon == 0) && (Playerdata.stone >= Playerdata.up_stoimost_stone) && (Playerdata.food >= Playerdata.up_stoimost_food) && (Playerdata.population >= Playerdata.up_stoimost_people))
        {
            Playerdata.stone -= Playerdata.up_stoimost_stone;
            Playerdata.food -= Playerdata.up_stoimost_food;
            Playerdata.population -= Playerdata.up_stoimost_people;
            Playerdata.food_day -= Playerdata.up_stoimost_people;
            //up_ogran_population = up_ogran_population * 1.1f;
            //Debug.Log(Mathf.Round(up_ogran_population));
            Playerdata.population_day += 15;
            Playerdata.food_day -= 15;
            Playerdata.feigh -= 1;

        }
        
        if ((Playerdata.rescon == 1) && (Playerdata.stone >= Playerdata.up_stoimost_stone) && (Playerdata.food >= Playerdata.up_stoimost_food) && (Playerdata.population >= Playerdata.up_stoimost_people))
        {
            Playerdata.stone -= Playerdata.up_stoimost_stone;
            Playerdata.food -= Playerdata.up_stoimost_food;
            Playerdata.population -= Playerdata.up_stoimost_people;
            Playerdata.food_day -= Playerdata.up_stoimost_people;
            //up_ogran_population = up_ogran_population * 1.1f;
            //Debug.Log(Mathf.Round(up_ogran_population));
            Playerdata.stone_day += 10;
            Playerdata.feigh -= 1;
        }

        if ((Playerdata.rescon == 2) && (Playerdata.stone >= Playerdata.up_stoimost_stone) && (Playerdata.food >= Playerdata.up_stoimost_food) && (Playerdata.population >= Playerdata.up_stoimost_people))
        {
            Playerdata.stone -= Playerdata.up_stoimost_stone;
            Playerdata.food -= Playerdata.up_stoimost_food;
            Playerdata.population -= Playerdata.up_stoimost_people;
            
            //up_ogran_population = up_ogran_population * 1.1f;
            //Debug.Log(Mathf.Round(up_ogran_population));
            Playerdata.food_day += 100;
            Playerdata.feigh -= 1;
        }

        if ((Playerdata.rescon == 3) && (Playerdata.stone >= Playerdata.up_stoimost_stone) && (Playerdata.food >= Playerdata.up_stoimost_food) && (Playerdata.population >= Playerdata.up_stoimost_people))
        {
            Playerdata.stone -= Playerdata.up_stoimost_stone;
            Playerdata.food -= Playerdata.up_stoimost_food;
            Playerdata.population -= Playerdata.up_stoimost_people;
            Playerdata.food_day -= Playerdata.up_stoimost_people;
            //up_ogran_population = up_ogran_population * 1.1f;
            //Debug.Log(Mathf.Round(up_ogran_population));
            Playerdata.weapon_day += 10;
            Playerdata.feigh -= 1;
        }

        
    }
}
   
    

