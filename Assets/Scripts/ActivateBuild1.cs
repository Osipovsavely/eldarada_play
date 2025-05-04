using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ActivateBuild1 : MonoBehaviour
{
    [SerializeField] GameObject food_b, stone_b, weapon_b, people_b;
    void Start()
    {
        food_b.SetActive(Playerdata.food_portal);
        stone_b.SetActive(Playerdata.stone_portal);
        weapon_b.SetActive(Playerdata.weapon_portal);
        people_b.SetActive(Playerdata.people_portal);

    }
}
