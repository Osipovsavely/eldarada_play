using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class wallController : MonoBehaviour
{
    //[SerializeField] TMP_Text 
    [SerializeField] GameObject panelwall;
    
    public void OnMouseDown() 
    {
        panelwall.SetActive(true);
    }
}
