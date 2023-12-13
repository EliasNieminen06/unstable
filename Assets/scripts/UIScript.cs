using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class UIScript : MonoBehaviour
{
    public TextMeshProUGUI lagerCount;
    public TextMeshProUGUI pigeonCount;
    public GameObject player;
    public GameObject gamemanager;

    // Update is called once per frame
    void Update()
    {
        int count = player.GetComponent<ThrowScript>().totalThrows;
        lagerCount.text = count.ToString() + " / 20 lagers left";
    }
}
