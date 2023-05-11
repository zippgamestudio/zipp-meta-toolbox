using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;
using UnityEngine.UI;

public class MenuManager : CoreGameObject
{
    private Dictionary<string, GameObject> pages;
    private Dictionary<string, GameObject> popups;
    public GameObject canvas;
    public string pagesPath;
    public string popupsPath;
    public string startPageName;
    public Vector3 startPageScale;
    public Vector3 endPageScale;
    public Vector3 startPpopupScale;
    public Vector3 endPopupScale;

    public override void Start()
    {
        base.Start();
        pages = new Dictionary<string, GameObject>();
        popups = new Dictionary<string, GameObject>();
        foreach (var x in Resources.LoadAll<UnityEngine.GameObject>(pagesPath))
        {
            pages.Add(x.name, x);
        }
        foreach (var y in Resources.LoadAll<UnityEngine.GameObject>("Menu/Popups"))
        {
            popups.Add(y.name, y);
        }
        OpenPage(startPageName);
        Debug.Log(gameManager);
    }

    public void ChangePage(GameObject currentPage, string nextPageName)
    {
        OpenPage(nextPageName);
        ClosePage(currentPage);
    }

    void OpenPage(string PageName)
    {
        GameObject page = pages[PageName];
        page = Instantiate(page, canvas.transform);
        page.transform.localScale = startPageScale;
        page.transform.DOScale(endPageScale, 1f);
    }

    public void ClosePage(GameObject page)
    {
        StartCoroutine(ClosePageTimer(page));
    }

    IEnumerator ClosePageTimer(GameObject page)
    {
        page.transform.DOScale(0f, 1f);
        yield return new WaitForSeconds(1f);
        Destroy(page.gameObject);
    }

    public void OpenPopup(string popupName)
    {
        GameObject popup = popups[popupName];
        popup = Instantiate(popup, canvas.transform);
        popup.transform.localScale = new Vector3(0f, 0f, 1f);
        popup.transform.DOScale(1f, 1f);
    }

    public void ClosePopup(GameObject popup)
    {
        StartCoroutine(ClosePopupTimer(popup));
    }

    IEnumerator ClosePopupTimer(GameObject popup)
    {
        popup.transform.DOScale(0f, 1f);
        yield return new WaitForSeconds(1f);
        Destroy(popup.gameObject);
    }
}
