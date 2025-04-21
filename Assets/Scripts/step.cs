using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class s : MonoBehaviour
{
    //[SerializeField] int steps = 0;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void step()
    {
        Playerdata.step =+ 1;
        Playerdata.weapon =+ Playerdata.weapon_day;
        Playerdata.stone =+ Playerdata.stone_day;
        Playerdata.food =+ Playerdata.food_day;
        Playerdata.population =+ Playerdata.population_day;
        
        //food =+ food_day

    }
}
