using UnityEngine;


public class Csharp_Practice_Parameter : MonoBehaviour
{
    void Print(int value)
    {
        Debug.Log(value);
    }

    void Print(string value)
    {
        Debug.Log(value);
    }

    void Print(float value)
    {
        Debug.Log(value);
    }

    //위와 같이 이름이 같은 함수는 매개변수로 구분합니다.
    //갯수가 많으면 보기 힘들어지므로, 형식 매개변수를 이용합니다.
    //형식 매개변수 T : 불특정 타입의 매개변수를 받을 때 사용합니다.

    void Print2<T>(T value) //T는 Type의 약자입니다.
    {
        Debug.Log(value);
    }

    //형식 매개변수의 경우, 올수 있는 Type을 명시해줄 수 있습니다.

    void Print3<T>(T value) where T : struct
        //where T에는 struct, class, interface 등이 들어갈 수 있습니다.
    {
        Debug.Log(value);
    }




    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Print(5); //int
        Print("ABCD"); //string
        Print(1.5f); //float

        Print2<string>("abc"); // string이 T값으로 들어가며, value 값에 abc가 들어갑니다.
        Print2<float>(4.5f); // float가 T값으로 들어가며, value 값에 4.5가 들어갑니다.

        //Print3<string>("abc"); //string은 class Type 이기 때문에 오류가 발생합니다. 
        Print3<float>(4.5f);  //float는 struct Type이기 때문에 오류가 발생하지 않습니다. (where T를 변환해보는걸 추천합니다.)

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
