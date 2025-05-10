using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class Playerdata
{
    public static int res_contr, rescon, proverka, main_person, attak;
    public static int build_x = 1;
    public static int step;//ход
    public static int stone_day;//камень
    public static int weapon_day;//оружие
    public static int food_day = 1000;//еда
    public static int population_day;//население
    public static int up_stoimost_stone, up_stoimost_people, up_stoimost_food;
    //public static int minus_food

    public static int stone = 300;
    public static int weapon = 200;
    public static int food = 10000;
    public static int population = 600;

    //Для стены
    
    public static int stone_HP = 1000; 
    public static int weapon_HP = 200;
    public static int people_HP = 200;
    public static int stone_HP_max = 10000;
    public static int people_HP_max = 3000;
    public static int weapon_HP_max = 2000;
    public static int pechat_people_full, pechat_stone_full, pechat_weapon_full;

    public static bool people_portal = false;
    public static bool stone_portal = false;
    public static bool weapon_portal = false;
    public static bool food_portal = false;

    public static bool event_4_controll = false;
    public static bool event_5_controll = false;
    public static bool event_6_controll = false;

    public static bool massage_controll_stone = true;
    public static bool massage_controll_people = true;
    public static bool massage_controll_weapon = true;
    public static bool massage_controll_food = true;

    public static int koncovka;
    public static bool kocovka_bool = true;
    public static int random_controll_events;
    public static int feigh = 20;
    public static float govermentbonus = 0.5f;
    public static bool angry_feigh;
    public static int tourch;
    public static bool tourch_controll;
    public static bool education = true;
    


}
