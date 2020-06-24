using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.Linq;
/*
 * 此类用于控制各级UI界面的打开和关闭
 * 此类设计为单例模式
 * 
 */
public class MenuManager : MonoBehaviour
{
    public static MenuManager instance;//单例模式
    private void Awake()
    {
        instance = this;
        Debug.Log("MenuManager Awake()");
    }
    private void Start()
    {
        buttonOfClosingSeetings.onClick.AddListener(delegate () {
            settingsMenu.SetActive(false);
            Debug.Log("关闭设置面板");
        });
    }
    public Button buttonOfClosingSeetings; //Settings->Back按钮，用来退出Settings面板
    public GameObject settingsMenu;//储存Settings面板
    public GameObject[] menuidOne ={};//储存一级菜单{Map，Generals}
    public GameObject[] menuidTwo = { };//储存二级菜单{Generals_1,Generals_2}
    Stack<GameObject> StackOfMenu=new Stack<GameObject>();//控制菜单层级
    public GameObject currentCity=null;//记录当前所在场地（City或者MainTent）,null表示在营帐中。

    /*private static void MyDic(string key)
    {
        Dictionary<string, int> StrToInt = new Dictionary<string, int>() {
            ["Map"] = 0,
            ["Generals"] = 1
        };
        //if (StrToInt.ContainsKey("Map")) {   }
        
        foreach (var item in StrToInt.Keys)
        {
            if (key == item) { }
        }
    }*///别管这个

    public void PushMenu_1(string menuName,int level)
    {//当需要打开一级界面时，调用此函数，参数为（一级菜单名，1）
        int id=0,st= StackOfMenu.Count();
        switch (menuName)
        {
            case "Map": id = 0; break; 
            case "Generals": id = 1; break;
        }
        Debug.Log("id="+id+"//level="+level+ "//StackOfMenu.Count()=" + st);
        if (st < level)
        {
            Debug.Log("打开菜单");
            StackOfMenu.Push(menuidOne[id]);
            menuidOne[id].SetActive(true);
        }else if (st == level)
        {
            Debug.Log("关闭旧菜单，打开新菜单");
            StackOfMenu.Peek().SetActive(false);
            StackOfMenu.Pop();
            StackOfMenu.Push(menuidOne[id]);
            menuidOne[id].SetActive(true);
        }
        else
        {//for循环清理栈，SetActiveRecursively()清理菜单及子菜单
            Debug.Log("循环隐藏子菜单");
            for(int i=0;i< st - level + 1; i++)
            {
                StackOfMenu.Peek().SetActive(false);
                StackOfMenu.Pop();
            }
            StackOfMenu.Push(menuidOne[id]);
            menuidOne[id].SetActive(true);
        }
    }
    public void PushMenu_2(string menuName, int level)
    {//当需要打开二级界面时，调用此函数，参数为（二级菜单名，2）
        int id = 0,st= StackOfMenu.Count();
        switch (menuName)
        {
           case "Generals_1": id = 0; break;
           case "Generals_2": id = 1; break;
        }
        Debug.Log("id=" + id + "//level=" + level);
        Debug.Log("StackOfMenu.Count()=" + st);
        if (st < level)
        {
            Debug.Log("打开菜单");
            StackOfMenu.Push(menuidTwo[id]);
            menuidTwo[id].SetActive(true);
        }
        else if (st == level)
        {
            Debug.Log("关闭旧菜单，打开新菜单");
            StackOfMenu.Peek().SetActive(false);
            StackOfMenu.Pop();
            StackOfMenu.Push(menuidTwo[id]);
            menuidTwo[id].SetActive(true);
        }
        else
        {//for循环清理栈，SetActiveRecursively()清理菜单及子菜单
            Debug.Log("循环隐藏子菜单");
            for (int i = 0; i < st - level + 1; i++)
            {
                StackOfMenu.Peek().SetActive(false);
                StackOfMenu.Pop();
            }
            StackOfMenu.Push(menuidTwo[id]);
            menuidTwo[id].SetActive(true);
        }
    }
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape)) { settingsMenu.SetActive(true);  }//监听esc键，esc被按下时，打开设置面板（settings）
    }
    public void CloseSettings()
    {
        settingsMenu.SetActive(false);
    }
    public void ChangeCity(GameObject go)
    {
        if (currentCity) { currentCity.SetActive(false);}
        currentCity = go;
    }
    public void CloseCity()
    {
        currentCity = null;
    }
    public void GoBack()
    {//点击settings面板的Back按钮时，调用此函数
        if (currentCity) { currentCity.SetActive(false); }
        currentCity = null;
    }
}
