using UnityEngine;
using LYN;
using LYN.Studio; // LYN.Studio 네임스페이스를 사용하여 해당 네임스페이스에 정의된 클래스나 멤버에 접근할 수 있도록 합니다.

// NameSpace를 사용하는 이유는 다음과 같습니다.
// 협업과 코드 관리
// 대형 프로젝트에서는 여러 개발자가 동시에 작업하기 때문에, 네임스페이스를 사용하여 클래스와 멤버를 그룹화하면 충돌을 방지하고 코드 관리를 용이하게 할 수 있습니다.
// 외부 라이브러리와의 충돌 방지

namespace LYN // LYN 네임스페이스를 정의하여 해당 네임스페이스에 관련된 클래스나 멤버를 그룹화합니다.
{
    
    public class Youtube
        //Class의 이름이 같은 경우, NameSpace로 구분하여 사용한다.
    {
        public int subscribe;
    }
    namespace Studio // LYN.Studio 네임스페이스를 정의하여 해당 네임스페이스에 관련된 클래스나 멤버를 그룹화합니다.
    {
        public class Youtube // Youtube 클래스를 정의하여 해당 클래스에 관련된 멤버를 포함합니다.
        {
            int like;

            public void setLike(int value)
            {
                like = value;
            }

            public bool isLike()
            {
                return like !=0 ;
            }
        }
    }
}
public class Csharp_Practice_NameSpace : MonoBehaviour
{

    LYN.Studio.Youtube lyn = new LYN.Studio.Youtube();
    //Youtube lyn = new Youtube();
    //같은 이름의 Youtube 클래스가 LYN 네임스페이스와 LYN.Studio 네임스페이스에 각각 정의되어 있으므로, 구분이 필요합니다. 
    //youtube 클래스의 인스턴스를 생성하여 lyn 변수에 할당합니다. 이 인스턴스를 통해 Youtube 클래스의 멤버에 접근할 수 있습니다.
    //using.LYN.Studio를 삭제할 경우 Namespace를 찾을 수 없다는 오류가 발생합니다. 따라서 using LYN.Studio;는 삭제할 수 없습니다.

    LYN.Youtube lyn2 = new LYN.Youtube();

    void Start()
    {
        
        lyn.setLike(5);
        //lyn 인스턴스의 setLike 메서드를 호출하여 like 값을 5로 설정합니다.
        //이 메서드는 Youtube 클래스에 정의된 멤버로, like 값을 설정하는 역할을 합니다.
        Debug.Log(lyn.isLike());
        //lyn 인스턴스의 isLike 메서드를 호출하여 like 값이 0이 아닌지 확인하고, 그 결과를 디버그 로그로 출력합니다.
        //이 메서드는 Youtube 클래스에 정의된 멤버로, like 값이 0이 아닌 경우 true를 반환하고, 그렇지 않은 경우 false를 반환하는 역할을 합니다.

        lyn2 = new LYN.Youtube();

        lyn2.subscribe = 5;

        Debug.Log(lyn2.subscribe);
        //lyn2 인스턴스의 subscribe 멤버에 5를 할당하고, 그 값을 디버그 로그로 출력합니다.
    }


}
