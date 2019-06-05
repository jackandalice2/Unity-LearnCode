using UnityEngine;

public class Dog
{
    #region 欄位
    public string name;
    public float weight;
    public string type;
    public string sex;
    public int age;
    #endregion

    #region 方法
    /// <summary>
    /// 狗狗亂叫方式
    /// </summary>
    public void Bark()
    {
        Debug.Log(name + "汪汪");
    }

    /// <summary>
    /// 轉換狗狗年齡的方法
    /// </summary>
    /// <returns></returns>
    public int ConvertAge()
    {
        return age * 7;
    }
    #endregion
}