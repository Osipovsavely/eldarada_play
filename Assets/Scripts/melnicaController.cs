using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class melnicaController : MonoBehaviour
{

    [SerializeField] TMP_Text res;
    [SerializeField] TMP_Text in_day_text;
    [SerializeField] TMP_Text stoimost_stone, stoimost_food, stoimost_people;
    [SerializeField] GameObject panel;
    // Start is called before the first frame update
    public void OnMouseDown() 
    { 
        panel.SetActive(true);
        //Playerdata.population += 1;
        //Playerdata.res_contr = 1;
        Playerdata.rescon = 3;
        res.text = "оружие";
        Playerdata.up_stoimost_stone = 200;
        Playerdata.up_stoimost_people = 10;
        Playerdata.up_stoimost_food = 20;
        Playerdata.food_day -= 20;
        stoimost_stone.text = Playerdata.up_stoimost_stone.ToString();
        stoimost_people.text = Playerdata.up_stoimost_people.ToString();
        stoimost_food.text = Playerdata.up_stoimost_food.ToString();

        in_day_text.text = Playerdata.weapon_day.ToString();

    } 

}
