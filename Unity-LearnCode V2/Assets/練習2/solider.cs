using System;
using UnityEngine;

[System.Serializable]
public class Solider
{
    public int exp;  //經驗值
    public int lv;   //等級

    /// <summary>
    /// 設定經驗值，計算經驗值為:等級 乘上 10
    /// </summary>
    /// <returns></returns>

    public int GetExp()
    {
        exp = lv * 10;
        return exp;
    }

    internal string SetExp()
    {
        throw new NotImplementedException();
    }

    /// <summary>
    /// 設定經驗值
    /// </summary>
    /// <param name="getExp"></param>
    public void SetExp(int getExp)
    {
        exp = getExp;
    }
}
