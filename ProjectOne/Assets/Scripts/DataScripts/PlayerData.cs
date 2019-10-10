using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu]
public class PlayerData : GameArtData
{
    public FloatData health;
    public List<WeaponData> weapons;
    public ClothesData shirt;
    public ClothesData pants;
}