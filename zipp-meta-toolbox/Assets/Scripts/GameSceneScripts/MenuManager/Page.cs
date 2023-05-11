using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Page : CoreGameObject
{
    public void GoToPage(string pageName)
    {
        gameManager.menuManager.ChangePage(this.gameObject, pageName);
    }

    public void OpenPopup(string popupName)
    {
        gameManager.menuManager.OpenPopup(popupName);
    }
}
