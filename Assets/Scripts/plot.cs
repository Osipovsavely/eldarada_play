using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class plot : MonoBehaviour
{
    [SerializeField] GameObject event_object_1, event_object_2, event_object_3, event_object_4, event_object_5, portal, portal_3D, wall_panel;
    //int main_person; //0-игрок, 1 - генерал альваро, 2 - новобранец хосе 

    public void event_1_say_tue()
    {
        event_object_1.SetActive(false);
    }
    public void event_1_say_false()
    {
        event_object_1.SetActive(false);
    }
    public void event_1_no_say()
    {
        event_object_1.SetActive(false);
    }


    public void event_2_no()
    {
        event_object_2.SetActive(false);
        Playerdata.main_person = 2;
    }
    public void event_2_yes()
    {
        event_object_2.SetActive(false);
        Playerdata.main_person = 0;
    }
    public void event_2_fiftififti()
    {
        event_object_2.SetActive(false);
        Playerdata.main_person = 1;
    }


    public void event_3()
    {
        event_object_3.SetActive(false);
        portal.SetActive(true);
        portal_3D.SetActive(true);
    }


    public void event_4_alvara()
    {
        event_object_4.SetActive(false);
        Playerdata.stone -= 150;
        Playerdata.population -= 300; 
        Playerdata.build_x = 1;
    }
    public void event_4_fiftififti()
    {
        event_object_4.SetActive(false);
        Playerdata.stone -= 100;
        Playerdata.population -= 200; 
        Playerdata.build_x = 2;
    }
    public void event_4_vozd()
    {
        event_object_4.SetActive(false);
        Playerdata.stone -= 50;
        Playerdata.population -= 100; 
        Playerdata.build_x = 3;
    }


    public void event_5()
    {
        event_object_5.SetActive(false);
        wall_panel.SetActive(true);
    }
}
