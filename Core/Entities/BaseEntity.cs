namespace Core.Entities
{
    public abstract class IEntity<TKey>
    {
        public TKey Id { get; private set; }
    }
}