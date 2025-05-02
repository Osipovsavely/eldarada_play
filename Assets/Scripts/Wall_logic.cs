using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Wall_logic : MonoBehaviour
{
    [SerializeField] GameObject panelwall, pechat_stone, pechat_weapon, pechat_people;
    [SerializeField] TMP_Text stoneHP_text, weaponHP_text, peopleHP_text;
    //int stone_HP_max = 10000;
    //int people_HP_max = 3000;
    //int weapon_HP_max = 2000;
    //int stone_HP, weapon_HP, people_HP;
    //stoneHP.text = Playerdata.stone_HP.ToString();
    

    
    void Update()
    {
        stoneHP_text.text = Playerdata.stone_HP + "/" + Playerdata.stone_HP_max;
        weaponHP_text.text = Playerdata.weapon_HP + "/" + Playerdata.weapon_HP_max;
        peopleHP_text.text = Playerdata.people_HP + "/" + Playerdata.people_HP_max;
        if (Playerdata.pechat_people_full == 0)
        {
            pechat_people.SetActive(false);
        }
        if (Playerdata.pechat_weapon_full == 0)
        {
            pechat_weapon.SetActive(false);
        }
        if (Playerdata.pechat_stone_full == 0)
        {
            pechat_stone.SetActive(false);
        }
    }

    public void Wall_UP_stone()
    {
        if ((Playerdata.stone >= 400) && (Playerdata.pechat_stone_full != 1))
        {
            Playerdata.stone_HP += 400;
            Playerdata.stone -= 400;
            pechat_stone.SetActive(true);
            Playerdata.pechat_stone_full = 1;
        }

        
        
    }
    public void Wall_UP_people()
    {  
        if ((Playerdata.population >= 200) && (Playerdata.pechat_people_full != 1))
        {
            Playerdata.people_HP += 200;
            Playerdata.population -= 200;
            pechat_people.SetActive(true);
            Playerdata.pechat_people_full = 1;
        }
        
    }
    public void Wall_UP_weapon()
    {
        if ((Playerdata.weapon >= 100) && (Playerdata.pechat_weapon_full != 1))
        {
            Playerdata.weapon_HP += 100;
            Playerdata.weapon -= 100;
            pechat_weapon.SetActive(true);
            Playerdata.pechat_weapon_full = 1;
        }
    }
}
