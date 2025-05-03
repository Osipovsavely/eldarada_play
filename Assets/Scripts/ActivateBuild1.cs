using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ActivateBuild1 : MonoBehaviour
{
    [SerializeField] GameObject food_b, stone_b, weapon_b, people_b;
    public void activate_food()
    {
        food_b.SetActive(true);
    }

    public void activate_stone()
    {
        stone_b.SetActive(true);
    }

    public void activate_weapon()
    {
        weapon_b.SetActive(true);
    }

    public void activate_people()
    {
        people_b.SetActive(true);
    }
}
