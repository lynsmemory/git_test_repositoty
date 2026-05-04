using UnityEngine;


//struct와 class의 차이점
//과거에는 struct를 이용하여 코딩을 했습니다.
//C언어가 발전하면서 class가 생겼습니다.
//struct는 구버전, class는 신버전이라고 생각하시면 됩니다.
//struct는 상속이 불가능하지만, class는 상속이 가능합니다.
//예로 public struct Youtube : MonoBehaviour {}는 오류가 발생합니다.
//struct는 MonoBehaviour를 상속할 수 없기 때문입니다.
//struct를 Class로 바꿀경우 new Youtube()로 객체를 생성할 수 있지만,
//struct는 객체를 생성할 때 new 키워드를 사용하지 않고도 필드에 직접 접근하여 값을 할당할 수 있습니다.
//struct는 값 타입
//a = 10 의 경우, a에 접근하면 바로 10이 나옵니다.
//class는 주소 타입
//a = 10 의 경우, a에 접근하면 a가 저장된 주소가 나오고, 그 주소에 접근하여 10이 나옵니다.



public struct Youtube
{
    //int a = 5;
    //Class와 달리 Struct는 직접 값을 할당할 수 없습니다.
    public int a;
    public int b;
    public int c;
    public int d;

    public Youtube(int _a, int _b, int _c, int _d)
    //public의 class 혹은 struct의 이름과 동일하게 생성자를 정의하여, 해당 생성자를 통해 구조체의 필드에 값을 할당할 수 있습니다.
    //데이터의 갯수에 맞게 파라미터 값을 받아주고, 매칭시켜주면 됩니다. 
    {
        a = _a;
        b = _b;
        c = _c;
        d = _d;
    }

    public void GetA(int value)
        // GetA 메서드는 정수형 매개변수 value를 받아서, a 필드에 해당 값을 할당하는 역할을 합니다.
    {
        a = value;
         // a 필드에 value 값을 할당하여, GetA 메서드를 호출한 후에는 a 필드에 해당 값이 저장됩니다.
    }
}


public class Csharp_Practice_Struct : MonoBehaviour
{

    int a;

    //생성자란 클래스나 구조체의 이름과 동일한 메서드를 정의하여, 해당 메서드를 통해 객체를 생성할 때 필요한 초기화 작업을 수행할 수 있도록 하는 특별한 메서드입니다.
    //아래와 같이 Youtube 구조체에 생성자를 정의하여, 해당 생성자를 통해 구조체의 필드에 값을 할당할 수 있습니다.
    Youtube LYN = new Youtube(1, 2, 3, 4);
    Youtube LYN2 = new Youtube(5, 6, 7, 8);

    void Start()
    {
        LYN.a = 5;
        // LYN 구조체의 a 필드에 5를 할당합니다.
        LYN.GetA(5);
        // LYN 구조체의 GetA 메서드를 호출하여, a 필드에 5를 할당합니다.
        Debug.Log(LYN.a);
        // LYN 구조체의 a 필드 값을 디버그 로그로 출력합니다. 이 경우, a 필드에는 5가 저장되어 있으므로, 5가 출력됩니다.
    }


}

public enum item
//enum은 enumeration의 약자로, 무언가를 열거하다라는 의미입니다.
//enum의 경우 넣고 싶은 값만 고를 수 있습니다.
//만약 Weapon, Shield, Potion 이외의 값을 넣으려고 하면, 오류가 발생합니다.
//엉뚱한 값을 넣는 것을 방지하기 위해 enum을 사용합니다.
{
    Weapon,
    Shield,
    Potion,
}

public class Csharp_Practice_Enum : MonoBehaviour
{
    item item;
    void Start()
    {
        item = item.Weapon;
        item = item.Shield;
        //마지막으로 할당된 값이 item에 저장됩니다. 따라서, item에는 item.Shield가 저장됩니다.

        Debug.Log(item);
        // item 변수의 값을 디버그 로그로 출력합니다. 이 경우, item에는 item.Shield가 저장되어 있으므로, "Shield"가 출력됩니다.

    }
}
