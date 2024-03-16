namespace Mission10API.Data
{
    public class EFBowlerRepository : IBowlingRepository
    {
        private readonly BowlingContext _bowlingContext;

        public EFBowlerRepository(BowlingContext temp)
        {
            _bowlingContext = temp;
        }

        public IEnumerable<BowlingLeague> Players => _bowlingContext.Players;
    }
}
