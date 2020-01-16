namespace BillShare.Contracts
{
    public partial interface ICopyable<T>
    {
        void CopyProperties(T other);
    }
}
