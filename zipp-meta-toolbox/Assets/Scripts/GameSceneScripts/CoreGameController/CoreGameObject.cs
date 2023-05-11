using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class CoreGameObject : MonoBehaviour
{
    [HideInInspector]
    public GameManager gameManager;
    public virtual void Start()
    {
        gameManager=GameObject.Find("GameManager").GetComponent<GameManager>();
    }

}
