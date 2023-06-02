using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class InfoButton : MonoBehaviour
{
    private void OnMouseEnter()
    {
        GameObject.Find("InfoText").GetComponent<MeshRenderer>().enabled = true;
    }
    private void OnMouseExit()
    {
        GameObject.Find("InfoText").GetComponent<MeshRenderer>().enabled = false;
    }
}
