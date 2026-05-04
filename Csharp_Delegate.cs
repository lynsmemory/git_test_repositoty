using UnityEngine;

public class Csharp_Delegate : MonoBehaviour
{

    //레벨이 올라갈 때마다 Power와 Defence가 증가하는 시스템을 만들었다.
    //아래 주석처리 된 것처럼 만들 수 있지만, 값이 많아지면 코드가 길어지고, 관리하기 어려워진다.
    //그래서 Delegate를 이용하여 코드를 간결하게 만들 수 있다.
    //int power;
    //int defence;
    //

    //public void SetPower(int value)
    //{
    //    power += value;
    //    Debug.Log("Power의 값이" + value + "만큼 증가했습니다. 총 Power의 값 = " + power);
    //}
    //public void SetDefence(int value)
    //{
    //    defence += value;
    //    Debug.Log("Defence의 값이" + value + "만큼 증가했습니다. 총 Defence의 값 = " + defence);
    //}
    //void Start()
    //{
    //    SetPower(5);
    //    SetDefence(5);
    //}


    //Delegate는 하나의 클래스 안에 있는 함수들을 추가하여 한번에 호출하는 기능입니다.
    //하나의 클래스 안에 있는 함수들을 모두 관리감독이 가능합니다.
    public delegate void ChainFunction(int value);
    ChainFunction chain;

    int power;
    int defence;

    public void SetPower(int value)
    {
        power += value;
        Debug.Log("Power의 값이" + value + "만큼 증가했습니다. 총 Power의 값 = " + power);
    }
    public void SetDefence(int value)
    {
        defence += value;
        Debug.Log("Defence의 값이" + value + "만큼 증가했습니다. 총 Defence의 값 = " + defence);
    }



    void Start()
    {
        chain += SetPower;
        chain += SetDefence;

        chain(5);
        //chain에 SetPower와 SetDefence 메서드를 추가하여, chain을 호출할 때마다 두 메서드가 순차적으로 실행되도록 합니다.

        chain -= SetDefence;
        chain -= SetPower;
        //위와 같이 chain에서 SetDefence와 SetPower 메서드를 제거하여 호출되지 않도록 할 수 있습니다.

        if (chain != null)
        {
            chain(5);
        }
        //chain에서 SetDefence와 SetPower 메서드를 제거한 후에 chain을 호출하면 NullReferenceException이 발생합니다.
        //그러므로 if문을 이용하여 chain이 null이 아닌 경우에만 호출하도록 하는 것이 좋습니다.
    }

    //event는 다른 모든 Class에 대해서 함수를 추가시키고, 한번에 호출시킬 수 있습니다.
    //Delegate를 받아서 사용하는 Event는 타 Class까지 함수를 모두 관리감독 할 수 있습니다.
    public static event ChainFunction OnStart;
    int power2;
    int defence2;

    public void SetPower2(int value)
    {
        power += value;
        Debug.Log("Power2의 값이" + value + "만큼 증가했습니다. 총 Power2의 값 = " + power);
    }
    public void SetDefence2(int value)
    {
        defence += value;
        Debug.Log("Defence2의 값이" + value + "만큼 증가했습니다. 총 Defence2의 값 = " + defence);
    }



    void Update() // delegate의 void Start()와 중복되므로 기록 편의 상 Update로 변경합니다.
    {
        OnStart += SetPower2;
        OnStart += SetDefence2;

        OnStart(5);
        //chain에 SetPower와 SetDefence 메서드를 추가하여, chain을 호출할 때마다 두 메서드가 순차적으로 실행되도록 합니다.

        OnStart -= SetDefence2;
        OnStart -= SetPower2;
        //위와 같이 chain에서 SetDefence와 SetPower 메서드를 제거하여 호출되지 않도록 할 수 있습니다.

        if (OnStart != null)
        {
            OnStart(5);
        }
        //chain에서 SetDefence와 SetPower 메서드를 제거한 후에 chain을 호출하면 NullReferenceException이 발생합니다.
        //그러므로 if문을 이용하여 chain이 null이 아닌 경우에만 호출하도록 하는 것이 좋습니다.
    }


    private void OnDisable()
        //게임이 꺼지거나, 객체가 비활성화되면 호출되는 함수입니다.
    {
        OnStart(5);
        //게임을 종료 할 경우, Abc 함수와 Csharp_Delegate의 SetPower, SetDefence 총 3개의 함수가 한번에 출력됩니다.
    }


}
