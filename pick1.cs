using UnityEngine.UI;
using UnityEngine;


public class Tackb : MonoBehaviour
{
 
    private bool canCollect = false;
    //判断是否进入碰撞域
    private GameObject target;
    //对象target
    [SerializeField] Transform ItemSlot;
    [SerializeField] Transform Item;
    public Text Money;
    public int moneynum1 = 0;
    //“手”
    void Update()
    {
        
        
        //一旦检测到按下e且符合能拾取条件，就拾取
        
    }
public void OnTriggerStay(Collider other)
    
    {
     if(other.CompareTag("Player"))
     {
        canCollect = true;
        target = other.gameObject;
        if (Input.GetKeyDown(KeyCode.E)&&canCollect==true)
        {
            AudioSource audio = GetComponent<AudioSource>();
            audio.time = 48;
            audio.Play();
            Item.transform.SetParent(ItemSlot);             //设立父对象
            Item.transform.localEulerAngles = Vector3.zero; //设置相对于父对象的角度为0
            Item.transform.localPosition = Vector3.zero;    //设置相对于父对象的位置为0
            

        }
        if(Input.GetKeyDown(KeyCode.Q))
           {
              AudioSource audio = GetComponent<AudioSource>();
              audio.Stop();
              Item.transform.SetParent(null);
              moneynum1 += 1919810;
              Money.text = "money:"+moneynum1.ToString();
           }
        
    
    
    }
  // 判断名称，设置可拾取状态，并将目前碰撞到的对象引用给予target
//     if (other.gameObject.name == "Hambuger")
//     {
      
//       //Debug.Log("success");
//       canCollect = true;
//       target = other.gameObject;

//     }
//     }
    

//     private void OnTriggerExit(Collider other)
//     {
//   // 退出碰撞箱范围，禁用拾取，解除target的引用
//     if (other.gameObject.name == "Hambuger")
//     {
//       canCollect = false;
//       target = null;
//     }
    }
     

}
    // 在player.cs中添加如下代码
// private void OnTriggerStay(Collider other)
// {
//   // 检测发送碰撞物体的tag为Item，表示可以被拾取
//   if (other.gameObject.tag == "Item")
//   {
//       Debug.Log("与物品碰撞，按E拾取物体");
//       if (Input.GetKeyDown(KeyCode.E))
//       {
//           // 销毁物体，表示拾取物品
//           Destroy(other.gameObject);
//           Debug.Log("物体已经被拾取");
//       }
//   }
// }


