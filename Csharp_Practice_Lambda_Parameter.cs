using UnityEngine;

public class Csharp_Practice_Lambda_Parameter : MonoBehaviour
{

    delegate void MyDelegate<T>(T a, T b); // Type T와 매개변수 2개를 추가합니다.
    MyDelegate<int> myDelegate; // <>안에는 int, string 등 요구에 맞는 타입을 넣습니다.



    void Start()
    {
        myDelegate += (int a, int b) => Debug.Log(a + b);
        //위에서 int로 정의하였기에, int a, int b를 입력해줍니다.
        myDelegate(3, 5);
        //int로 정의하였기에 정수 3, 5를 추가하였습니다.


    }

    
}
