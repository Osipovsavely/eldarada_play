using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class wallController : MonoBehaviour
{
    //[SerializeField] TMP_Text 
    [SerializeField] GameObject panelwall;
    [SerializeField] TMP_Text stoneHP_text, weaponHP_text, peopleHP_text;
    int wallcontr = 0;
    
    public void OnMouseDown() 
    {
        if ((wallcontr == 0) && (Playerdata.step >= 20))
        {
            panelwall.SetActive(true);
            wallcontr = 1;
            stoneHP_text.text = Playerdata.stone_HP + "/" + Playerdata.stone_HP_max;
            weaponHP_text.text = Playerdata.weapon_HP + "/" + Playerdata.weapon_HP_max;
            peopleHP_text.text = Playerdata.people_HP + "/" + Playerdata.people_HP_max;
        }
        else
        {
            panelwall.SetActive(false);
            wallcontr = 0;
        }
        
    }
}
