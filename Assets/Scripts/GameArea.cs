﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameArea : MonoBehaviour
{
    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.GetComponent<Ball>() != null)
        {
            EventSystem.StartGame();
        }
    }
}
