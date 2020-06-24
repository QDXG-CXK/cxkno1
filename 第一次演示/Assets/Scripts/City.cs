using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/*
 * 
 *这个类暂时先不用管 
 * 以后用来实例化城池或者作为父类继承用
 * 
 * 
 * 
 */
public class City : MonoBehaviour
{
   
    public int ID=0;
    public string cityName="空";
    City(int id,string n) { ID = id;name = n; }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void OpeningCityOne()
    {
        gameObject.SetActive(true);
        Debug.Log("打开城池"+ID.ToString());
    }
    public void ClosingCityOne()
    {
        gameObject.SetActive(false);
        Debug.Log("关闭城池"+ID.ToString());
    }
}
