using Fusion;
using UnityEngine;

public class PlayersSpwaner : SimulationBehaviour,IPlayerJoined
{
    [SerializeField] GameObject[] playerCars;
    [SerializeField] Transform spawnPositionsParent;
    Vector3[] spawnPositions;
    private void Awake()
    {
        spawnPositions=new Vector3[spawnPositionsParent.childCount];
        for(int i = 0; i < spawnPositionsParent.childCount; i++)
        {
            spawnPositions[i]=spawnPositionsParent.GetChild(i).position;
        }
    }
    public void PlayerJoined(PlayerRef player)
    {
        int playerNumber = Runner.SessionInfo.PlayerCount - 1;
        if (player == Runner.LocalPlayer)
            Runner.Spawn(playerCars[playerNumber], spawnPositions[playerNumber]);
    }
}
