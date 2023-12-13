using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class UIScript : MonoBehaviour
{
    public TextMeshProUGUI lagerCount;
    public GameObject player;

    // Update is called once per frame
    void Update()
    {
        int count = player.GetComponent<ThrowScript>().totalThrows;
        lagerCount.text = count.ToString() + " / 20";
    }
}
