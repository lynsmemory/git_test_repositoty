//8-1. 클래스
//class : 하나의 사물(오브젝트)와 대응하는 로직
//public class 클래스명(파일명)
//접근제한자 : public(모든 곳에서 접근 가능), private(같은 클래스 내에서만 접근 가능), protected(같은 클래스와 상속받은 클래스에서 접근 가능)
//일반적으로 private가 기본값이므로, 접근제한자를 생략하면 private로 설정됨


public class Csharp_Practice_Class
{
    public int id;
    public string name;
    public string title;
    public string weapon;
    public float strength;
    public int level;

    public string Talk()
    {
        return "대화를 걸었습니다.";
    }

    public string HasWeapon()
    {
        return weapon;
    }

    public void LevelUp()
    {
        level = level + 1;
    }

}
