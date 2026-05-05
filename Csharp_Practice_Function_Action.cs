using System;
using UnityEngine;

public class Csharp_Practice_Function_Action : MonoBehaviour
{
    delegate void MyDelegate<T1, T2>(T1 a, T2 b);
    MyDelegate<int, int> myDelegate;
    //Action과 Function의 차이
    //반환 타입의 유무로 결정
    //현재 void는 없으므로 Action을 사용합니다. 

    Action<int, int> myDelegate1;

    delegate string MyDelegate2<T1, T2>(T1 a, T2 b);
    MyDelegate2<int, int> myDelegate2;
    //반환값이 있는 string이므로 Func을 사용합니다. 

    Func<int, int, string> myDelegate3;



    void Start()
    {
        myDelegate3 = (int a, int b) => { int sum = a + b; return sum + "이 리턴되었습니다."; };

        Debug.Log(myDelegate3(3, 5));
    }

  
}
