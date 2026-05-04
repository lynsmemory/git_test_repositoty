using UnityEngine;

public class Csharp_Practice_Event : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Csharp_Delegate.OnStart += Abc;
        //Onstart에는 아래 Abc 함수와 Csharp_Delegate의 SetPower, SetDefence 총 3개의 함수가 한번에 담기게 됩니다. 
    }

    public void Abc(int Value)
    //int Value를 넣는 이유는, Csharp_Delegate에서 ChainFunction이 int value를 매개변수로 받기 때문입니다.
    //만약 int Value를 제거한다면, Csharp_Delegate도 ChainFunction이 매개변수(파라미터)를 받지 않도록 수정해야 합니다.
    {
        Debug.Log(Value + "값이 증가했습니다.");

    }


    // Update is called once per frame
    void Update()
    {
        
    }
}
