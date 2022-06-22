﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AddScore100 : MonoBehaviour
{
    public CarController carController;

    private void OnTriggerEnter2D(Collider2D collision){
        Text score = GameObject.Find("Canvas/Score").GetComponent<Text>();
        carController.score += 100;

        score.text = carController.score.ToString();
        Destroy(gameObject);
    }
}
