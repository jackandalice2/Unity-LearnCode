using System;

[System.Serializable]
public class Warrior
{
    public int exp;
    public int lv;

    /// <summary>
    /// 戰士經驗值
    /// </summary>
    public int Exp
    {
        get
        {
            return lv * 10;
        }
        set
        {
            exp = value;
        }
    }

    internal void exp(int v)
    {
        throw new NotImplementedException();
    }

    internal string exp()
    {
        throw new NotImplementedException();
    }
}
