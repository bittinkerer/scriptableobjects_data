using Packages.Estenis.GameData_;
using UnityEngine;

namespace Packages.Estenis.ScriptableObjectsData_
{
    [CreateAssetMenu(menuName = "SOData/GameDataVector2SOData")]
    public class GameDataVector2SOData : BaseSOData<GameDataVector2>
    {
        public GameDataVector2SOData()
        {
            Data = new GameDataVector2();
        }
    }
}
