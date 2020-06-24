using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/*
 * 
 * 
 * 
 * 
 */ 
public class CityOne : MonoBehaviour
{
    public void TryChanging()
    {
        MenuManager.instance.ChangeCity(gameObject);
        gameObject.SetActive(true);
    }
    public void TryClosing()
    {
        MenuManager.instance.CloseCity();
        gameObject.SetActive(false);
        Debug.Log("关闭城池一");
    }
    public void OpeningCityOne()
    {
        gameObject.SetActive(true);
        Debug.Log("打开城池一");
    }
    public void ClosingCityOne()
    {
        gameObject.SetActive(false);
        Debug.Log("关闭城池一");
    }
}
