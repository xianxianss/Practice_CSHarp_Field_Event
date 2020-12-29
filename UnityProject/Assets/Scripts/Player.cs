using UnityEngine;

public class Player : MonoBehaviour
{

    [Header("移動速度"), Range(0, 100)]
    public float Speed = 10f;
    [Header("跳躍高度"), Range(0, 2000)]
    public int Jump = 200;
    [Header("對話內容")]
    public string Talk = ("咕咕咕~~~");
    [Header("是否取得權重")]
    public bool Egg = false;

    private void Start()
    {
        print("遊戲開始!!!");

    }

    private void Update()
    {
        print(Talk);
    }







}
