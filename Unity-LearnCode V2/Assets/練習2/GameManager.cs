using UnityEngine;

public class GameManager:MonoBehaviour
{
    public Solider SoliderA = new Solider();

    public void Start()
    {
        SoliderA.lv = 30;
        Debug.Log("士兵經驗值、取得:" + SoliderA.GetExp());

        SoliderB.lv = 30;
        Debug.Log("士兵經驗值、取得:" + SoliderB.GetExp());
    }
}