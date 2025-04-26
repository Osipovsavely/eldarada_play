using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Wall_logic : MonoBehaviour
{
    [SerializeField] GameObject panelwall;
    [SerializeField] TMP_Text stoneHP, weaponHP, peopleHP;
    int stone_HP_max = 1000;
    //stoneHP.text = Playerdata.stone_HP.ToString();
    
    void Start()
    {

    }
}
