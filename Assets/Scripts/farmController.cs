using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class farmController : MonoBehaviour
{
    
    [SerializeField] TMP_Text res;
    [SerializeField] TMP_Text in_day_text;
    [SerializeField] TMP_Text stoimost_stone, stoimost_food, stoimost_people;
    // Start is called before the first frame update
    public void OnMouseDown() 
    { 
        //Playerdata.population += 1;
        //Playerdata.res_contr = 1;
        Playerdata.rescon = 2;
        res.text = "еда";
        Playerdata.up_stoimost_stone = 10;
        Playerdata.up_stoimost_people = 100;
        Playerdata.up_stoimost_food = 60;
        stoimost_stone.text = Playerdata.up_stoimost_stone.ToString();
        stoimost_people.text = Playerdata.up_stoimost_people.ToString();
        stoimost_food.text = Playerdata.up_stoimost_food.ToString();

        in_day_text.text = Playerdata.food_day.ToString();

    } 

}
