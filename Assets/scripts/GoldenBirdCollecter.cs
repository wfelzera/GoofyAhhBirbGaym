using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class GoldenBirdCollecter : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.name == "birb")
        {
            //Debug.Log("GOLDEN_BIRB");
            PlayerPrefs.SetInt("gb", 1);
            GetComponent<SpriteRenderer>().enabled = false;
            GameObject.Find("GbFoundText").GetComponent<TMP_Text>().enabled = true;
            GameObject.Find("GbFoundText").GetComponent<GBFT>().timer = 1f;

            GameObject.Find("birb").GetComponent<SpriteRenderer>().sprite = GameObject.Find("GameManager").GetComponent<GoldenBirdApplyer>().gb1;
            GameObject.Find("birb").GetComponent<BirdAnimation>().sprite1 = GameObject.Find("GameManager").GetComponent<GoldenBirdApplyer>().gb1;
            GameObject.Find("birb").GetComponent<BirdAnimation>().sprite2 = GameObject.Find("GameManager").GetComponent<GoldenBirdApplyer>().gb2;
            GameObject.Find("birb").GetComponent<BirdAnimation>().sprite3 = GameObject.Find("GameManager").GetComponent<GoldenBirdApplyer>().gb3;
        }
    }
}
