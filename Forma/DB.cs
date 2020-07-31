using MySql.Data.MySqlClient;

namespace RegistreAddress
{
    /*
         we need to download the mysql connector
         * add the connector to our project
         * ( watch the video to see how ) 
         * create a connection now with mysql
         * open xampp and start mysql & apache
         * go to phpmyadmin and create the users database
         */

    class DB
    {

        private MySqlConnection connection = new MySqlConnection("server=localhost;port=3306;username=root;password=;database=registre_address");


        // create a function to open the connection
        public void openConnection()
        {
            if (connection.State == System.Data.ConnectionState.Closed)
            {
                connection.Open();
            }
        }

        // create a function to close the connection
        public void closeConnection()
        {
            if (connection.State == System.Data.ConnectionState.Open)
            {
                connection.Close();
            }
        }

        // create a function to return the connection
        public MySqlConnection getConnection()
        {
            return connection;
        }
    }
}