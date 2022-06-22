using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EndPoint : MonoBehaviour
{
    Collider EndTarget = new Collider();

    private void OnTriggerEnter(Collider other) 
    {
        SceneManager.LoadScene("GameWon");
    }
}