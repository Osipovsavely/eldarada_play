using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using TMPro;

public class PlayerController : MonoBehaviour
{
    [SerializeField] Image interfase, buttum_next;
    [SerializeField] int wall_HP = 1000;
    [SerializeField] TMP_Text weapont, stonet, foodt, populationt, stept;
    [SerializeField] GameObject Button_P1, Button_P2;

    void Start()
    {
        

    }

    void Update()
    {
        weapont.text = Playerdata.weapon.ToString();
        stonet.text = Playerdata.stone.ToString();
        foodt.text = Playerdata.food.ToString();
        populationt.text = Playerdata.population.ToString();
        stept.text = Playerdata.step.ToString();

    }

}
