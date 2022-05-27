namespace LeaveManagement.Web.Data
{
    public abstract class BaseEnity
    {
        public int Id { get; set; }
        public DateTime DateCreated { get; set; }
        public DateTime DateModified { get; set; }
    }
}
