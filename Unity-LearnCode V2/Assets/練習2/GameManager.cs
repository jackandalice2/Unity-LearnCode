using UnityEngine;

public class GameManager:MonoBehaviour
{
    public Solider SoliderA = new Solider();
    public Warrior WarriorA = new Warrior();


    public void Start()
    {
        SoliderA.lv = 30;
        Debug.Log("士兵經驗值、取得:" + SoliderA.GetExp());

        SoliderA.SetExp  (100);
        Debug.Log("士兵經驗值、取得:" + SoliderA.SetExp());

        WarriorA.lv = 50;
        Debug.Log("士兵經驗值、取得:" + WarriorA.exp());

        WarriorA.exp(150);
        Debug.Log("士兵經驗值、取得:" + WarriorA.exp());
    }
}