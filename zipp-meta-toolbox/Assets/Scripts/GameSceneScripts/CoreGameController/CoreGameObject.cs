using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoreGameObject : MonoBehaviour
{
    GameManager gameManager;
    void Start()
    {
        gameManager=GameObject.Find("GameManager").GetComponent<GameManager>();
    }

}
