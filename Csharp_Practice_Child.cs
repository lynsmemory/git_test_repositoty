using UnityEngine;

public class Csharp_Practice_Child : Csharp_Practice_Parent
//Csharp_Practice_Child는 Csharp_Practice_Parent를 상속받아서
//humanName과 humanAge를 사용할 수 있게됩니다.
{
    string schoolName;

    void Start()
    {
        schoolName = "ROSchool";
        humanName = "LYN";
        humanAge = 30;

        info();
        //부모클래스의 함수 호출이 가능합니다.
    }
    //자식클래스에서 다시 정의 하고 싶은 경우, 부모 클래스에서 virtual을 추가해줍니다. - Parent 이동
    protected override void info2()
        //override는 재정의 한다는 뜻입니다.
    {
        base.info2();
        //base는 부모클래스 입니다.
        Debug.Log("나는 아침을 먹지 않았습니다.");
        //자식 함수에서 부모함수의 값을 변경하여 출력하므로, "나는 아침을 먹지 않았습니다."가 출력됩니다.
    }

    protected override void Name()
    {
        Debug.Log(humanName);
    }
    //코드가 너무 길어질 경우 이름을 출력하는 함수를 잊어버릴 수 있습니다.
    //이럴 경우 부모 Class에서 반드시 만들어야 한다고 명시할 수 있습니다. - Parents 이동

}
