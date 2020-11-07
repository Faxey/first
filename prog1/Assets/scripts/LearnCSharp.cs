
using UnityEngine;

public class LearnCSharp : MonoBehaviour
{
    public int hp = 100;
    public float speed = 1.5f;
    public string skill = "66666";
    public bool mission = false;
    public Color skin = Color.black;
    public Vector3 posStart = new Vector3(30, 1, 50);
    public GameObject trap;

    public void Move() //移動方式
    {
        print("移動中");
    }

    public void Hit(float getDamage)//受傷方法
    {
        print("受到傷害:"+getDamage);
    }

    public void Jump(float height,string aniName)
    {
        print("跳躍高度:"+height);
        print("跳躍動畫:" + aniName);
    }

    private void Start()
    {
        Move();
        Hit(999.9f);
    }

    private void Update()
    {
        Jump(150.5f, "前滾翻");
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        
    }
}
