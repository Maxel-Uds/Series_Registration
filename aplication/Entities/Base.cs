namespace aplication
{
    public abstract class Base
    {
        public int Id { get; protected set; }
        
        protected Base(int id)
        {
            Id = id;
        }
    }
}