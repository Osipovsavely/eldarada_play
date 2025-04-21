using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using TMPro;

public class PlayerController : MonoBehaviour
{
    [SerializeField] Image interfase, buttum_next;
    //[SerializeField] public int weapon, stone, food, population;
    [SerializeField] int wall_HP = 1000;
    [SerializeField] TMP_Text weapont, stonet, foodt, populationt;
    [SerializeField] GameObject Button_P1, Button_P2;
    //public int weapon, stone, food, population;

    // Start is called before the first frame update
    void Start()
    {
        Playerdata.weapon = 200f;
        Playerdata.stone = 200f;
        Playerdata.food = 10000f;
        Playerdata.population = 500f;
    }

    // Update is called once per frame
    void Update()
    {
        weapont.text = Playerdata.weapon.ToString();
        stonet.text = Playerdata.stone.ToString();
        foodt.text = Playerdata.food.ToString();
        populationt.text = Playerdata.population.ToString();
        
        //
        //if (SceneManagement.GetActiveScene().name=="neworld") 
    }




    
    


}
