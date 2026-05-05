using UnityEngine;

public class Csharp_Lambda : MonoBehaviour
{

    int a = 5;
    int b = 5;

    int sum;

    void Add()
    {
        sum = a + b;
        Back();
    }

    void Back()
    {
        sum = 0;
    }

    delegate void MyDelegate();
    MyDelegate myDelegate;

    void Start()
    {
        myDelegate = Add;
        //무명 메소드 : 함수를 만들지 않아도, Delegate에 넣을 수 있습니다.
        //무명 메소드는 delegate를 통해서만 호출이 가능합니다.
        myDelegate += delegate () { Debug.Log(sum); };
        //람다식
        //람다식의 기본 문법 = (int a) => return a;
        //매개변수 a를 받고, 그 a를 반환하는 람다식
        myDelegate += () => Debug.Log(sum);

        myDelegate += Back;

        myDelegate();
    }

    
}
