using UnityEngine;

public class Dogmanager : MonoBehaviour

{
# region 欄位
    public Dog DogA = new Dog();
    public Dog DogB = new Dog();
#endregion


# region 事件
    private void Start()
    {
        DogA.name = "永揚";
        DogA.weight = 30.5f;
        DogA.type = "吉娃娃";
        DogA.sex = "公";
        DogA.colar = "黑";
        DogA.age = 7;

        DogB.name = "志承";
        DogB.weight =40.5f;
        DogB.type = "吉娃娃";
        DogB.sex = "公";
        DogB.colar = "白";
        DogB.age = 7;

        Debug.Log(DogA.name + "品種:" + DogA.type + "顏色:" + DogA.colar);
        Debug.Log(DogB.name + "品種:" + DogB.type + "顏色:" + DogB.colar);

        DogA.Bark();
        DogB.Bark();

        Debug.Log(DogA.name + "的實際年齡為" + DogA.ConvertAge());
        Debug.Log(DogB.name + "的實際年齡為" + DogB.ConvertAge());

        DogA.Eat("熱狗");
        DogB.Eat("薯條",10);

    
    }

    #endregion

}
