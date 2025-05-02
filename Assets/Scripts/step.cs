using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class s : MonoBehaviour
{
    [SerializeField]int step_max = 100;
    [SerializeField] GameObject lose_menu, win_menu, pechat_stone, pechat_weapon, pechat_people, event_object_2;
    [SerializeField] TMP_Text stoneHP_text, weaponHP_text, peopleHP_text;
    //[SerializeField] int steps = 0;

    // Start is called before the first frame update
    void Start()
    {
        //Playerdata.stone_HP = 2000;
        //Playerdata.weapon_HP = 1000;
        //Playerdata.people_HP = 1000;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void step()
    {
        Playerdata.step += 1;
        Playerdata.weapon += Playerdata.weapon_day;
        Playerdata.stone += Playerdata.stone_day;
        Playerdata.food += Playerdata.food_day - Playerdata.people_HP;
        Playerdata.population += Playerdata.population_day;
        //Playerdata.food_day -= Playerdata.population
        //if (SceneManager == 0)
        pechat_stone.SetActive(false);
        pechat_weapon.SetActive(false);
        pechat_people.SetActive(false);
        stoneHP_text.text = Playerdata.stone_HP + "/" + Playerdata.stone_HP_max;
        weaponHP_text.text = Playerdata.weapon_HP + "/" + Playerdata.weapon_HP_max;
        peopleHP_text.text = Playerdata.people_HP + "/" + Playerdata.people_HP_max;

        Playerdata.pechat_people_full = 0;
        Playerdata.pechat_weapon_full = 0;
        Playerdata.pechat_stone_full = 0;

        if (Playerdata.step > step_max) 
        {
            if ((Playerdata.weapon < 1000) || (Playerdata.food < 0))
            {
                lose_menu.SetActive(true);
                Time.timeScale = 0;
            }
            else
            {
                win_menu.SetActive(true);
                Time.timeScale = 0;
            }
        }
        if (Playerdata.step == 1)
        {
            event_object_2.SetActive(true);
        }
    }

}
