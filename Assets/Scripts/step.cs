using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class s : MonoBehaviour
{
    [SerializeField]int step_max = 100;
    [SerializeField] GameObject lose_menu, win_menu, pechat_stone, pechat_weapon, pechat_people, event_object_1, event_object_2, event_object_3, event_3_alvaro, event_3_hose, event_3_yoy, event_object_4, event_object_5, event_object_6, portal;
    [SerializeField] GameObject not_plot_event_1, not_plot_event_2, not_plot_event_3, massage_, end_1;
    [SerializeField] TMP_Text stoneHP_text, weaponHP_text, peopleHP_text, massage_text, massage_text_answe;
    int random_controll_batlle;
    [SerializeField] GameObject feigh_1_5, feigh_2_5, feigh_3_5, feigh_4_5, feigh_5_5;
    //public Image feigh_1_5, feigh_2_5, feigh_3_5, feigh_4_5, feigh_5_5;
    float just_weapon_day;
    float just_food_day;
    float just_stone_day;
    float just_people_day;


    //bool massage_controll_stone = true;
    //bool massage_controll_people = true;
    //bool massage_controll_weapon = true;
    //bool massage_controll_food = true;




    void Start()
    {
        if (Playerdata.step >= 3)
        {
            portal.SetActive(true);
        }
        if (Playerdata.feigh <= 20)
        {
            feigh_1_5.SetActive(true);
        }
        else
        {
            feigh_1_5.SetActive(false);
        }
        if ((Playerdata.feigh >= 20) && (Playerdata.feigh < 40))
        {
            feigh_2_5.SetActive(true);
        }
        else
        {
            feigh_2_5.SetActive(false);
        }
        if ((Playerdata.feigh >= 40) && (Playerdata.feigh < 60))
        {
            feigh_3_5.SetActive(true);
        }
        else
        {
            feigh_3_5.SetActive(false);
        }
        if ((Playerdata.feigh >= 60) && (Playerdata.feigh < 80))
        {
            feigh_4_5.SetActive(true);
        }
        else
        {
            feigh_4_5.SetActive(false);
        }
        if ((Playerdata.feigh >= 80) && (Playerdata.feigh <= 100))
        {
            feigh_5_5.SetActive(true);
        }
        else
        {
            feigh_5_5.SetActive(false);
        }
    }
    

    void Update()
    {
        
    }
    public void step()
    {
       

        Playerdata.step += 1;

        if ((Playerdata.main_person == 1) && (Playerdata.main_person == 2) && (Playerdata.step == 4))
        {
            just_food_day = ((Playerdata.food_day - Playerdata.population - (Playerdata.people_HP*2)))*Playerdata.govermentbonus*(1-(Playerdata.feigh));
            just_weapon_day = Playerdata.weapon_day*Playerdata.govermentbonus*(1-(Playerdata.feigh));
            just_stone_day = Playerdata.stone_day*Playerdata.govermentbonus*(1-(Playerdata.feigh));
            just_people_day = Playerdata.population_day*Playerdata.govermentbonus*(1-(Playerdata.feigh));
        }
        else
        {
            just_food_day = (Playerdata.food_day - Playerdata.population - (Playerdata.people_HP*2))*Playerdata.govermentbonus*Playerdata.feigh;
            just_weapon_day = Playerdata.weapon_day*Playerdata.govermentbonus*Playerdata.feigh;
            just_stone_day = Playerdata.stone_day*Playerdata.govermentbonus*Playerdata.feigh;
            just_people_day = Playerdata.population_day*Playerdata.govermentbonus*Playerdata.feigh;
        }
        
        //float just_weapon_day = Playerdata.weapon_day*Playerdata.govermentbonus;
        //float just_stone_day = Playerdata.stone_day;
        //float just_people_day = Playerdata.population_day;
        
        Playerdata.stone += Mathf.RoundToInt(just_stone_day);
        Playerdata.food += Mathf.RoundToInt(just_food_day);
        Playerdata.population += Mathf.RoundToInt(just_people_day);
        Playerdata.weapon += Mathf.RoundToInt(just_weapon_day);

        //Playerdata.food_day -= Playerdata.population
        //if (SceneManager == 0)
        pechat_stone.SetActive(false);
        pechat_weapon.SetActive(false);
        pechat_people.SetActive(false);

        stoneHP_text.text = Playerdata.stone_HP + "/" + Playerdata.stone_HP_max;
        weaponHP_text.text = Playerdata.weapon_HP + "/" + Playerdata.weapon_HP_max;
        peopleHP_text.text = Playerdata.people_HP + "/" + Playerdata.people_HP_max;

        Playerdata.stone_HP -= Playerdata.attak;
        Playerdata.people_HP -= Playerdata.attak;
        Playerdata.weapon_HP -= Playerdata.attak;

        Playerdata.pechat_people_full = 0;
        Playerdata.pechat_weapon_full = 0;
        Playerdata.pechat_stone_full = 0;

        //Поражение
        if ((Playerdata.weapon_HP <= 0) || (Playerdata.stone_HP <= 0) || (Playerdata.people_HP <= 0))
        {
            lose_menu.SetActive(true);
            Time.timeScale = 0;
        }
        else if (Playerdata.food <= 0)
        {
            lose_menu.SetActive(true);
            Time.timeScale = 0;
        }

        
        if (Playerdata.step <= 25)
        {
            if (Playerdata.step == 1)
            {
                event_object_1.SetActive(true);
            }

            
            else if (Playerdata.step == 2)
            {
                event_object_2.SetActive(true);
            }
            else if (Playerdata.step == 3)
            {
                event_object_3.SetActive(true);
                if (Playerdata.main_person == 1)
                {
                    event_3_alvaro.SetActive(true);
                }
                else if (Playerdata.main_person == 2)
                {
                    event_3_hose.SetActive(true);
                }
                else if (Playerdata.main_person == 0)
                {
                    event_3_yoy.SetActive(true);
                }
            }
            else if ((Playerdata.step == 4) && (Playerdata.event_4_controll == false))
            {
                event_object_4.SetActive(true);
                Playerdata.event_4_controll = true;
            }
            else if ((Playerdata.step == 20) && (Playerdata.event_5_controll == false))
            {
                event_object_5.SetActive(true);
                Playerdata.event_5_controll = true;
                
            }
            else if ((Playerdata.step == 25) && (Playerdata.event_6_controll == false))
            {
                event_object_6.SetActive(true);
                Playerdata.event_6_controll = true;
                Playerdata.random_controll_events = Playerdata.step;
            }
        }

        

        if (Playerdata.step <= 20)
        {
            if (Playerdata.step >= (4+(1*Playerdata.build_x)))
            {
                if (Playerdata.massage_controll_stone == true)
                {
                    massage_text.text = "Хорошие новости! Наши рабочие достроили шахту в другом мире! Что бы начать добывать камень перейдите в другой мир, нажмите на шахту и улучшите её.";
                    Playerdata.massage_controll_stone = false;
                    massage_.SetActive(true);
                }
                Playerdata.stone_portal = true;
            }
            if (Playerdata.step >= (4+(2*Playerdata.build_x)))
            {
                if (Playerdata.massage_controll_food == true)
                {
                    massage_text.text = "Хорошие новости! Наши рабочие достроили ферму в другом мире! Что бы начать добывать еду перейдите в другой мир, нажмите на мельницу и улучшите её.";
                    Playerdata.massage_controll_food = false;
                    massage_.SetActive(true);
                }
                Playerdata.food_portal = true;
            }
            if (Playerdata.step >= (4+(3*Playerdata.build_x)))
            {
                if (Playerdata.massage_controll_people == true)
                {
                    massage_text.text = "Хорошие новости! Наши дипломаты установили дипломотические связи с людьми, живущими в паралельном мире! Они согласились поставлять нам людской ресурс, которого нам так не хватало! Что бы увеличить прерост людей улучшите посольство.";
                    Playerdata.massage_controll_people = false;
                    massage_.SetActive(true);
                }
                Playerdata.people_portal = true;
            }
            if (Playerdata.step >= (4+(4*Playerdata.build_x)))
            {
                if (Playerdata.massage_controll_weapon == true)
                {
                    massage_text.text = "Хорошие новости! Благодаря инвистициям и субсидиям из стран другого мира была построена мастерская! Улучшите её, что бы она начала производить оружие для вас.";
                    massage_text_answe.text = "Судсидии? Инвистиции? Чего?";
                    Playerdata.massage_controll_weapon = false;
                    massage_.SetActive(true);
                }
                Playerdata.weapon_portal = true;
            }
        }
        

        if ((Playerdata.step >= 30)&&(Playerdata.step+5 >= Playerdata.random_controll_events))
        {
            //int random_controll_batlle;
            int chance = Random.Range(0,31);
            if (chance == 10)
            {
                not_plot_event_1.SetActive(true);
                Playerdata.random_controll_events = Playerdata.step;

            }
            else if (chance == 20)
            {
                not_plot_event_2.SetActive(true);
                Playerdata.random_controll_events = Playerdata.step;

            }
            if (chance == 30)
            {
                not_plot_event_3.SetActive(true);
                Playerdata.random_controll_events = Playerdata.step;
            }
        }
        if (Playerdata.kocovka_bool == true)
        {
            if (Playerdata.koncovka == Playerdata.step)
            {
                if (Playerdata.koncovka == 120)
                {
                    end_1.SetActive(true);

                }
            }
        }
        if (Playerdata.feigh <= 20)
        {
            feigh_1_5.SetActive(true);
        }
        else
        {
            feigh_1_5.SetActive(false);
        }
        if ((Playerdata.feigh >= 20) && (Playerdata.feigh < 40))
        {
            feigh_2_5.SetActive(true);
        }
        else
        {
            feigh_2_5.SetActive(false);
        }
        if ((Playerdata.feigh >= 40) && (Playerdata.feigh < 60))
        {
            feigh_3_5.SetActive(true);
        }
        else
        {
            feigh_3_5.SetActive(false);
        }
        if ((Playerdata.feigh >= 60) && (Playerdata.feigh < 80))
        {
            feigh_4_5.SetActive(true);
        }
        else
        {
            feigh_4_5.SetActive(false);
        }
        if ((Playerdata.feigh >= 80) && (Playerdata.feigh < 100))
        {
            feigh_5_5.SetActive(true);
        }
        else
        {
            feigh_5_5.SetActive(false);
        }
    }
}
