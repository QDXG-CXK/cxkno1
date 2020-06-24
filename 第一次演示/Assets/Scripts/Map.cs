using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/*
 * 一级菜单Map
 * 此脚本挂载到同样名为Map的物体上
 * 
 * 
 * 
 */
public class Map : MonoBehaviour
{
    //public static Map instance;
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
        
        MenuManager.instance.PushMenu_1("Map",1);
    }
    public void OpeningMap()
    {
        gameObject.SetActive(true);
        Debug.Log("打开地图");
    }
    public void ClosingMap()
    {
        gameObject.SetActive(false);
        Debug.Log("关闭地图");
    }
}
