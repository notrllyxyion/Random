using UnityEngine;
using TMPro;

public class PlayerTwo : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI m_Text;
    private int Age = 21;
    private int PhysicalDamage = 25;
    private int Armor = 40;
    private int MagicDamage = 20;
    private int MagicResistance = 25; 
    private float Speed = 60.0f; 
    
    public void ButtonPressed()
    {
        m_Text.text = $"Name : Oh Haewon \n Age : {Age} \n Race : Asian \n Physical Damage: {PhysicalDamage} \n Armor: {Armor} \n Magic Damage {MagicDamage} \n Magic Resistance {MagicResistance} \n Speed {Speed}";
    }
}
