using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class wallController : MonoBehaviour
{
    //[SerializeField] TMP_Text 
    [SerializeField] GameObject panelwall;
    int wallcontr = 0;
    
    public void OnMouseDown() 
    {
        if (wallcontr == 0)
        {
            panelwall.SetActive(true);
            wallcontr = 1;
        }
        else
        {
            panelwall.SetActive(false);
            wallcontr = 0;
        }
        
    }
}
