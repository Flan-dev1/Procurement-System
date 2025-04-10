namespace Procurement_System.Models
{
    public class EmployeeAccount
    {
        public int Id { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public bool Enabled { get; set; } = false;
        public bool isLoggedIn { get; set; }
    }
}