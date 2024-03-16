namespace Mission10API.Data
{
    public interface IBowlingRepository
    {
        IEnumerable<BowlingLeague> Players { get; }
    }
}
