using UnityEngine;

public class Csharp_Practice_Propery2 : MonoBehaviour
{
    Csharp_Practice_Property mySalary = new Csharp_Practice_Property();

    void Start()
    {
        Debug.Log(mySalary.GetSalary());


        //mySalary.SetSalary(55);
        //보호수준 때문에 엑세스 할 수 없다는 오류가 발생합니다.

        //mySalary.SalaryP = 50;
        //set 앞에 private를 설정하였으므로 엑세스 할 수 없다는 오류가 발생합니다.
        Debug.Log(mySalary.SalaryP);
    }

}
