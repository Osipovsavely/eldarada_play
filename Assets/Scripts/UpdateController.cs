using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UpdateController : MonoBehaviour
{
    float up_ogran_population = 20.0f;
    
    public void Update_population()
    {
        if (Playerdata.stone >= up_ogran_population)
        {
            Playerdata.stone -= up_ogran_population;
            up_ogran_population = up_ogran_population * 1.1f;
            Debug.Log(Mathf.Round(up_ogran_population));
            Playerdata.population_day += 5;
            

        }
    }
}
