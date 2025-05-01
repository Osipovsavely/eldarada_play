using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class Portals : MonoBehaviour
{
    [SerializeField] TMP_Text stoneHP_text, weaponHP_text, peopleHP_text;
    public void portal_in_city()
    {
        SceneManager.LoadScene(0);
        ActiveWall();
        
    }
    public void portal_in_neworld()
    {
        SceneManager.LoadScene(1);
    }
    void ActiveWall()
    {
        stoneHP_text.text = Playerdata.stone_HP + "/" + Playerdata.stone_HP_max;
        weaponHP_text.text = Playerdata.weapon_HP + "/" + Playerdata.weapon_HP_max;
        peopleHP_text.text = Playerdata.people_HP + "/" + Playerdata.people_HP_max;
    }
    // Start is called before the first frame update
}
