namespace SOLID
{
    public class PasswordReminder
    {
        private MySQLConnection _dbConnection;
        public PasswordReminder(MySQLConnection dbConnection)
        {
            _dbConnection = dbConnection;
        }
    }
}