namespace MediatorExample
{
    public interface ICabCallCenter
    {
        void Register(ICab cab);
        void BookCab(IPassenger passenger);
    }
}
