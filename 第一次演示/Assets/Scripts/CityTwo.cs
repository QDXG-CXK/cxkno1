using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/*
 * 
 * 
 * 
 * 
 */
public class CityTwo  : MonoBehaviour 
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
        Debug.Log("关闭城池二");
    }

    public void OpeningCityTwo()
    {
        gameObject.SetActive(true);
        Debug.Log("打开城池二");
    }
    public void ClosingCityTwo()
    {
        gameObject.SetActive(false);
        Debug.Log("关闭城池二");
    }
}
