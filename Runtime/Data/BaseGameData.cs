using UnityEngine;

namespace Assets.Scripts.Game.ScriptableObjects.GameData
{
    
    public abstract class BaseGameData<T> : ScriptableObject
    {
        public T Data;
    }
}
