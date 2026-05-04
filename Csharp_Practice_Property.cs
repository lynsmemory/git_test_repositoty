using UnityEngine;

public class Csharp_Practice_Property : MonoBehaviour
{
    private int salary;

    private int bonus = 10;

    private void SetSalary(int value)
    {
        salary = value;
    }

    public int GetSalary()
    {
        return salary;
    }
    //타 Class에서 salary의 값을 수정할 수 없지만 읽어들일수는 있습니다.
    //이 중요한 변수의 은닉성에 대한 설정입니다.
    //민감한 변수가 많을수록 변수의 갯수만큼 *2가 필요합니다.

    //이 때 사용하는것이 Property 입니다.

    public int SalaryP { get { return salary; } private set { salary = value; }  }
    //타 Class에서 접근할 수 없게, set 앞에 private을 붙여줘야 합니다. (접근 제한자 설정)

    //public int SalaryP { get { return salary; }}
    //두번째 방법으로 위처럼 set값을 지워버릴 수도 있습니다.
    //단 salary의 값은 void Start란에 직접 입력해줘야 합니다. (salary = 20;과 같이)

    //public int SalaryP { get { return salary + bonus; }}
    //위와 같이 설정할 경우, salary 10의 값과 bonus의 10의 값이 더해져 20의 결과가 리턴됩니다. 

    //public int SalaryP { get { return salary + bonus; } set {if(value < 0) salary = 10; else salary = value;}}
    //set 내부에 조건문을 넣는 것도 가능합니다.
    //value의 값이 0보다 작을경우, 10이 출력됩니다. 양수의 경우 value의 값으로 치환합니다.

    //단순한 Property도 만들 수 있다.
    public int Pay { get; set; }
    //해당 Property는 변수의 역할도 합니다.



    void Start()
    {
        salary = 10;
        
        SalaryP = 10; // 10이 value 변수로 들어가게 됩니다. private int salary의 값 또한 10으로 변경됩니다.

        Debug.Log(SalaryP); //salary의 값을 가져옵니다.

        Pay = 20;
        Debug.Log (Pay);

        //Property의 대표적인 예로 배열의 Length 입니다.
        //(get이 들어가있음)
    }

    
}
