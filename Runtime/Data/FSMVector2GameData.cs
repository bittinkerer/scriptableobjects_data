using Assets.Scripts.Game.ScriptableObjects.GameData;
using Assets.Scripts.Game.StateMachine.Models;
using UnityEngine;

namespace Assets.Scripts.ScriptableObjects
{
    [CreateAssetMenu(menuName = "GameData/FSMVector2GameData")]
    public class FSMVector2GameData : BaseGameData<FSMDataVector2>
    {
        public FSMVector2GameData()
        {
            Data = new FSMDataVector2();
        }
    }
}
