using Fusion;
using UnityEngine;

public class PlayersSpwaner : SimulationBehaviour,IPlayerJoined
{
    [SerializeField] GameObject playerPrefab;
    public void PlayerJoined(PlayerRef player)
    {
        if (player == Runner.LocalPlayer)
            Runner.Spawn(playerPrefab, Vector3.zero);
    }
}
