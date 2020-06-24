using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
/*
 * Timer类用来控制游戏中的时间
 * 这个类设计成单例模式
 * 这个脚本挂载到同样名为Timer的GameObject上
 * 其他脚本在调用此单例类时，不再实例化（单例意味着只有一个实例） 
 * 任何脚本在任何时候都可以直接调用Timer.instance.< 函数名 > ();来使用Timer类的方法（函数）
 * ——by CXK
 * 
 * 
 */ 
public class Timer : MonoBehaviour
{
    public static Timer instance;//单例模式
    private void Awake()
    {
      
        instance = this;//给Timer类的单例赋值为此脚本
        Debug.Log("Timer Awake()");
    }

    float time=0;
    public Text timerText;
    //public void GetTime() { Debug.Log("GetTime()"); }
    private void FixedUpdate()
    {/*无需使用Update()逐帧计时，此函数每隔固定时间调用一次，可满足游戏计时要求.
      *在Unity的Edit->ProjectSettings->Time中修改时间间隔(fixed timestep)
      * 我设置的是0.1秒。       ——by CXK*/
        time += Time.deltaTime;
        timerText.text = "Time:" + time.ToString("F1");
        //Debug.Log(time);
    }
}
