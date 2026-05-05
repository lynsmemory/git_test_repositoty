using System.Collections;
using UnityEngine;


public class Record
{
    public int[] temp = new int[5];
    //String, Float도 가능합니다.
    //ArrayList, List도 활용 가능합니다.
    

    public int this[int index]
    //this = 해당 클래스를 지칭하는 예약어 입니다.
    {
        get
        {
            if (index >= temp.Length)
            {
                Debug.Log("인덱스가 너무 큽니다.");
                return 0;
            }
            else
            {
                return temp[index];
            }
        }
        set
        {
            if (index >= temp.Length)
            {
                Debug.Log("인덱스가 너무 큽니다.");
            }
            else
            {
                temp[index] = value;
            }
        }
        //만약 index의 값이 temp 배열의 크기보다 크거나 같다면 "인덱스가 너무 큽니다." 메세지를 출력합니다.
    }
        

}
public class Csharp_Indexer : MonoBehaviour
{

    Record record = new Record();


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        record[5] = 5;
        //record[5] <-- public int this[int index] 의 index값 입니다.
        //5; <-- set { temp[index] = value; }의 value 값 입니다.
        //위의 경우 인덱스가 너무 큽니다 메세지 출력
        
        record[3] = 5;
        //위의 경우 

        Debug.Log(record[3]);
        //위의 경우 값이 5로 출력됩니다.
        Debug.Log(record[5]);
        //위의 경우 인덱스가 너무 큽니다 메세지와 0이 출력됩니다.
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
