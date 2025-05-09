using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TourchController : MonoBehaviour
{
    [SerializeField] GameObject tourch_object;
    public void OnMouseDown() 
    {
        tourch_object.SetActive(true);
    }

   
}
