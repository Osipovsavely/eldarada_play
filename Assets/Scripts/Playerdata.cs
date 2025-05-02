using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class Playerdata
{
    public static int res_contr, rescon, proverka;
    public static float step;//ход
    public static float stone_day;//камень
    public static float weapon_day;//оружие
    public static float food_day;//еда
    public static float population_day;//население
    public static int up_stoimost_stone, up_stoimost_people, up_stoimost_food;
    //public static int minus_food

    public static float stone = 200;
    public static float weapon = 200;
    public static float food = 10000;
    public static float population = 500;

    //Для стены
    
    public static int stone_HP = 1000; 
    public static int weapon_HP = 200;
    public static int people_HP = 200;
    public static int stone_HP_max = 10000;
    public static int people_HP_max = 3000;
    public static int weapon_HP_max = 2000;
    public static int pechat_people_full, pechat_stone_full, pechat_weapon_full;
}
