using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MassageLogic : MonoBehaviour
{
    [SerializeField] GameObject massage_;
    public void cloze()
    {
        massage_.SetActive(false);
    }
}
