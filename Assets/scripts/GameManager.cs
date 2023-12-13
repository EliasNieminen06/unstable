using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public int pigeonCount = 12;

    private void Update()
    {
        if (pigeonCount == 0)
        {
            Application.Quit();
        }
    }

    public void pigeonDead()
    {
        pigeonCount--;
    }
}
