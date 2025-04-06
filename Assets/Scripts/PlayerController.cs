using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using TMPro;

public class PlayerController : MonoBehaviour
{
    [SerializeField] Image interfase, buttum_next;
    [SerializeField] int weapon, stone, food, population;
    [SerializeField] int wall_HP = 1000;
    [SerializeField] TMP_Text weapont, stonet, foodt, populationt;
    [SerializeField] GameObject Button_P1, Button_P2;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        weapont.text = weapon.ToString();
        stonet.text = stone.ToString();
        foodt.text = food.ToString();
        populationt.text = population.ToString();
        //
        //if (SceneManagement.GetActiveScene().name=="neworld") 
    }




    
    


}
