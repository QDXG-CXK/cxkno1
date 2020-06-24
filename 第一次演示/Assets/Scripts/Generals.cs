using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/*
 * 一级菜单Generals
 * 此脚本挂载到同样名为Generals的物体上
 * 
 * 
 * 
 */ 
public class Generals : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void TryOpening()
    {
        MenuManager.instance.PushMenu_1("Generals", 1);
    }
    public void TryClosing()
    {

    }
    public void OpeningGenerals()
    {
        gameObject.SetActive(true);
        Debug.Log("打开军官面板");
    }
    public void ClosingGenerals()
    {
        gameObject.SetActive(false);
        Debug.Log("关闭军官面板");
    }
}
