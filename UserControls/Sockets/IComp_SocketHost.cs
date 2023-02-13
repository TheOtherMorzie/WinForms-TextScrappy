namespace TextScrappy.UserControls.Sockets
{
    public interface IComp_SocketHost
    {
        bool HasSpawnPoint { get; }
        int SP_count { get; }
        Control.ControlCollection? SpawnPoint { get; }
        Control? SpawnPoint_Control { get; set; }
    }
}