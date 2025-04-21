using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using TMPro;

public class foresthouseControiier : MonoBehaviour
{
    [SerializeField] TMP_Text res;
    [SerializeField] TMP_Text in_day_text;
    // Start is called before the first frame update
    public void OnMouseDown() 
    { 
        //Playerdata.population += 1;
        //Playerdata.res_contr = 1;
        res.text = "люди";
        in_day_text.text = Playerdata.population_day.ToString();;

    } 
}
